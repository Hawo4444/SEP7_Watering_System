using DomainLayer.Models.SensorData;
using ServiceLayer.Services.ForecastDataServices;
using ServiceLayer.Services.SchedulerServices;
using ServiceLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceLayer.Services.SensorDataServices
{
    public class SensorDataServices : ISensorDataServices, ISensorDataRepository, IArduinoAccessSensors, IWateringSchedulerSensors
    {
        private ISensorDataRepository _sensorDataRepository;
        private IArduinoAccessSensors _arduinoAccess;
        private IWateringSchedulerSensors _wateringScheduler;

        public event EventHandler<SensorsUpdateEvent> _sensorsUpdateEvent = (s, e) => { };
        public event EventHandler<SensorsListEvent> _sensorsListEvent = (s, e) => { };

        private static Timer arduinoTimer;
        private const int arduinoRequestFrequency = 5000; // Frequency of arduino data requests

        public SensorDataServices(ISensorDataRepository sensorDataRepository, 
            IArduinoAccessSensors arduinoAccess, IWateringScheduler wateringScheduler)
        {
            _sensorDataRepository = sensorDataRepository;
            _arduinoAccess = arduinoAccess;
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
        }

        public void GetAndInsertSensorData()
        {
            InsertSensorData(GetSensorData());
        }

        // Used in the timer to poll and insert data and show them in the main view
        public void InsertSensorData(ISensorDataModel sensorDataModel)
        {
            _sensorDataRepository.InsertSensorData(sensorDataModel);
            _sensorsUpdateEvent(this, new SensorsUpdateEvent(sensorDataModel));
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
            _wateringScheduler.UpdateSensorDataInScheduler(sensorDataModel);
        }
    }
}
