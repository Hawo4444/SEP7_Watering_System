using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;
using System;

namespace ServiceLayer.Services.ForecastDataServices
{
    public interface IMainPresenter
    {
        event EventHandler SensorDataViewBindingDoneEventRaised;
        void UpdateForecastData(IForecastDataModel forecastDataModel);
        void UpdateCurrentSensorData(ISensorDataModel sensorDataModel);
    }
}