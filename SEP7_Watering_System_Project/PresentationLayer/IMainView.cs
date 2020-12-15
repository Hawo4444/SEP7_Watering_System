using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;
using PresentationLayer.Utility;
using System;

namespace PresentationLayer
{
    public interface IMainView
    {
        event EventHandler<EventClass> ViewEvent;
        void ShowMainView();
        void UpdateForecastData(IForecastDataModel forecastDataModel);
        void UpdateCurrentSensorData(ISensorDataModel sensorDataModel);
    }
}