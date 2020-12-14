using DomainLayer.Models.SensorData;
using ServiceLayer.Services.ForecastDataServices;
using ServiceLayer.Services.SchedulerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceLayer.Services.SensorDataServices
{
    public class SensorDataServices : ISensorDataServices, ISensorDataRepository, IArduinoAccess, IWateringSchedulerSensors
    {
        private ISensorDataRepository _sensorDataRepository;
        private IArduinoAccess _arduinoAccess;
        private IMainPresenter _mainPresenter;
        private IWateringSchedulerSensors _wateringScheduler;

        private static Timer arduinoTimer;
        private const int arduinoRequestFrequency = 5000; // To be changed

        public SensorDataServices(ISensorDataRepository sensorDataRepository, IArduinoAccess arduinoAccess,
            IMainPresenter mainPresenter, IWateringScheduler wateringScheduler)
        {
            _sensorDataRepository = sensorDataRepository;
            _arduinoAccess = arduinoAccess;
            _mainPresenter = mainPresenter;
            _wateringScheduler = wateringScheduler;
            GetAndInsertSensorData(); 
            SetTimer();
        }

        private void SetTimer()
        {
            if(arduinoTimer== null)
            {
                // Create a timer with an interval.
                arduinoTimer = new Timer(arduinoRequestFrequency);
                // Hook up the Elapsed event for the timer. 
                arduinoTimer.Elapsed += OnTimedEvent;
                arduinoTimer.AutoReset = true;
                arduinoTimer.Enabled = true;
            }            
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            GetAndInsertSensorData();
            _wateringScheduler.UpdateSensorDataInScheduler(GetSensorData());
            for (int i = 0; i < ((List<SensorDataModel>)RetrieveAllData()).Count; i++)
            {
                Console.WriteLine(((List<SensorDataModel>)RetrieveAllData())[i].TimeStamp);
            }
        }

        public void GetAndInsertSensorData()
        {
            InsertSensorData(GetSensorData());
        }

        // Used in the timer to poll and insert data and show them in the main view
        public void InsertSensorData(ISensorDataModel sensorDataModel)
        {
            _sensorDataRepository.InsertSensorData(sensorDataModel);
            _mainPresenter.UpdateCurrentSensorData(sensorDataModel);
        }

        public IEnumerable<SensorDataModel> RetrieveAllData()
        {
            return _sensorDataRepository.RetrieveAllData();
        }

        public SensorDataModel GetSensorData()
        {
            return _arduinoAccess.GetSensorData();
        }

        public void StopTimer()
        {
            if(!(arduinoTimer == null))
            {
                arduinoTimer.Enabled = false;
                arduinoTimer.Stop();
                arduinoTimer.Dispose();
            }
        }

        public void UpdateSensorDataInScheduler(ISensorDataModel sensorDataModel)
        {
            throw new NotImplementedException();
        }
    }
}
