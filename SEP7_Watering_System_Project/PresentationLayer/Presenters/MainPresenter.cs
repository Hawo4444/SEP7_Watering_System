using DomainLayer.Models.ForecastData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Services.ForecastDataServices;
using DomainLayer.Models.SensorData;
using PresentationLayer.Utility;

namespace PresentationLayer.Presenters
{
    class MainPresenter : IMainPresenter
    {
        public event EventHandler SensorDataViewBindingDoneEventRaised; //what about this

        IMainView _mainView;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
            mainView.ViewEvent += PresenterEventHandler;
        }

        public void PresenterEventHandler(Object sender, EventClass e)
        {
            Console.WriteLine(e.EventFired);
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
