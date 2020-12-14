using DomainLayer.Models.SensorData;

namespace ServiceLayer.Services.SensorDataServices
{
    public interface IArduinoAccess
    {
        SensorDataModel GetSensorData();
    }
}