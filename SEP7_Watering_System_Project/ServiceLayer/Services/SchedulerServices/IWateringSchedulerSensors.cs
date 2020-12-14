using DomainLayer.Models.SensorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.SchedulerServices
{
    public interface IWateringSchedulerSensors
    {
        void UpdateSensorDataInScheduler(ISensorDataModel sensorDataModel);
    }
}
