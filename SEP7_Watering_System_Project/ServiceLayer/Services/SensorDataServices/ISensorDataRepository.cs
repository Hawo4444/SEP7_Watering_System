using DomainLayer.Models.SensorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.SensorDataServices
{
    public interface ISensorDataRepository
    {
        void InsertSensorData(ISensorDataModel sensorDataModel);
        IEnumerable<SensorDataModel> RetrieveAllData();
    }
}
