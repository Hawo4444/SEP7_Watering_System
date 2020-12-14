using ServiceLayer.Services.SensorDataServices;
using ServiceLayer.Services.SchedulerServices;

namespace InfrastructureLayer.DataAccess.ArduinoAccess
{
    public interface IArduinoAccess : IArduinoAccessSensors, IArduinoAccessScheduler
    {
    }
}