using DomainLayer.Models.SensorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Utility
{
    public class SensorsListEvent : EventArgs
    {
        public IEnumerable<ISensorDataModel> _sensorDataList { get; private set; }

        public SensorsListEvent(IEnumerable<ISensorDataModel> sensorDataList)
        {
            _sensorDataList = sensorDataList;
        }
    }
}
