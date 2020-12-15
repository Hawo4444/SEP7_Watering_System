using DomainLayer.Models.SensorData;
using ServiceLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.SensorDataServices
{
    public interface ISensorDataServices
    {
        event EventHandler<SensorsUpdateEvent> _sensorsUpdateEvent;
        event EventHandler<SensorsListEvent> _sensorsListEvent;
        void StopTimer();
        IEnumerable<SensorDataModel> RetrieveAllData();
    }
}
