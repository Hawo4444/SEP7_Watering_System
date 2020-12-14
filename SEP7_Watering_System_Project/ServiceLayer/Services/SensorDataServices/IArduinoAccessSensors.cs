using DomainLayer.Models.SensorData;

namespace ServiceLayer.Services.SensorDataServices
{
    public interface IArduinoAccessSensors
    {
        SensorDataModel GetSensorData();
    }
}