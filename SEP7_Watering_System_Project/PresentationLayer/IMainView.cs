using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;

namespace PresentationLayer
{
    public interface IMainView
    {
        void ShowMainView();
        void UpdateForecastData(IForecastDataModel forecastDataModel);
        void UpdateCurrentSensorData(ISensorDataModel sensorDataModel);
    }
}