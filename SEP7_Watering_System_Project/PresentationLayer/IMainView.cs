using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;
using PresentationLayer.Utility;
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IMainView
    {
        event EventHandler<ViewEvent> _viewEvent;
        void ShowMainView();
        void UpdateForecastData(IForecastDataModel forecastDataModel);
        void UpdateCurrentSensorData(ISensorDataModel sensorDataModel);
        void OpenHistoricalDataView(IEnumerable<ISensorDataModel> sensorDataList);
    }
}