using DomainLayer.Models.ForecastData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Services.ForecastDataServices;
using DomainLayer.Models.SensorData;
using PresentationLayer.Utility;
using ServiceLayer.Services.SchedulerServices;
using ServiceLayer.Services.SensorDataServices;
using ServiceLayer.Utility;

namespace PresentationLayer.Presenters
{
    class MainPresenter : IMainPresenter
    {
        IMainView _mainView;
        IWateringScheduler _wateringScheduler;
        ISensorDataServices _sensorDataServices;
        IForecastDataServices _forecastDataServices;

        public MainPresenter(IMainView mainView, IWateringScheduler wateringScheduler, 
            ISensorDataServices sensorDataServices, IForecastDataServices forecastDataServices)
        {
            _mainView = mainView;
            mainView._viewEvent += PresenterEventHandler;

            _wateringScheduler = wateringScheduler;

            _sensorDataServices = sensorDataServices;
            _sensorDataServices._sensorsUpdateEvent += SensorDataUpdateEventHandler;
            _sensorDataServices._sensorsListEvent += SensorDataListEventHandler;

            _forecastDataServices = forecastDataServices;
            _forecastDataServices._forecastUpdateEvent += ForecastUpdateEventHandler;
        }

        public void PresenterEventHandler(Object sender, ViewEvent e)
        {
            switch (e._eventFired)
            {
                case "Water":
                    _wateringScheduler.Water();
                    break;
                case "GetSensorDataList":
                    _mainView.OpenHistoricalDataView(_sensorDataServices.RetrieveAllData());
                    break;
                case "ShowWateringSchedule":
                    // TODO
                    //_wateringScheduler.
                    break;
                default:
                    Console.WriteLine("Unhandled event in MainPresenter");
                    break;
            }
        }

        public void SensorDataUpdateEventHandler(Object sender, SensorsUpdateEvent e)
        {
            UpdateCurrentSensorData(e._sensorDataModel);
        }

        public void SensorDataListEventHandler(Object sender, SensorsListEvent e)
        {
            _mainView.OpenHistoricalDataView(e._sensorDataList);
        }

        public void ForecastUpdateEventHandler(Object sender, ForecastUpdateEvent e)
        {
            UpdateForecastData(e._forecastDataModel);
        }

        public void UpdateForecastData(IForecastDataModel forecastDataModel)
        {
            _mainView.UpdateForecastData(forecastDataModel);
        }

        public void UpdateCurrentSensorData(ISensorDataModel sensorDataModel)
        {
            _mainView.UpdateCurrentSensorData(sensorDataModel);
        }
    }
}
