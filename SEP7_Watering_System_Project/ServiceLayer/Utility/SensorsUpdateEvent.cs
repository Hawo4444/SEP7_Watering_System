using DomainLayer.Models.SensorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Utility
{
    public class SensorsUpdateEvent : EventArgs
    {
        public ISensorDataModel _sensorDataModel { get; private set; }

        public SensorsUpdateEvent(ISensorDataModel sensorDataModel)
        {
            _sensorDataModel = sensorDataModel;
        }
    }
}
