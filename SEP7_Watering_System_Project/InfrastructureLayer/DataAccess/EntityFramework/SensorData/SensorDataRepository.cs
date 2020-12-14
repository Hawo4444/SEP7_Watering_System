using DomainLayer.Models.SensorData;
using ServiceLayer.Services.SensorDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.EntityFramework.SensorData
{
    public class SensorDataRepository : ISensorDataRepository
    {
        public SensorDataRepository()
        {

        }

        public void InsertSensorData(ISensorDataModel sensorDataModel)
        {
            using (var context = new SensorDataDB())
            {
                context.SensorData.Add((SensorDataModel)sensorDataModel);
                context.SaveChanges();
            }
        }

        public IEnumerable<SensorDataModel> RetrieveAllData()
        {
            List<SensorDataModel> sensorDataModelList = new List<SensorDataModel>();

            using (var context = new SensorDataDB())
            {
                sensorDataModelList = context.SensorData.ToList();
            }

            return sensorDataModelList;
        }
    }
}
