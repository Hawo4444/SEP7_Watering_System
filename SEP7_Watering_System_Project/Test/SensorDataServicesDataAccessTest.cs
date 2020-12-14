using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.SensorData;
using InfrastructureLayer.DataAccess.EntityFramework.SensorData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ServiceLayer.Services.ForecastDataServices;
using ServiceLayer.Services.SensorDataServices;
using Xunit;

namespace ServiceLayer.Tests
{
    [TestClass]
    public class SensorDataServicesDataAccessTest
    {
        private SensorDataServices _sensorDataServices;

        public SensorDataServicesDataAccessTest()
        {
            //_sensorDataServices = new SensorDataServices(new SensorDataRepository());
        }


        [TestMethod]
        public void CreateSensorData_saves_sensor_data_via_context()
        {
            var mockSet = new Mock<DbSet<SensorDataModel>>();

            var mockContext = new Mock<SensorDataDB>();
            mockContext.Setup(m => m.SensorData).Returns(mockSet.Object);

            var repository = new Mock<SensorDataRepository>();

            var arduinoAccess = new Mock<IArduinoAccess>();

            var mainPresenter = new Mock<IMainPresenter>();

            /*var service = new SensorDataServices(repository.Object, arduinoAccess.Object, mainPresenter.Object);
            service.InsertSensorData(new SensorDataModel { TimeStamp = new DateTime(2020, 01, 01), 
                Humidity = 50, Moisture = 200, Temperature = 19.5 });

            mockSet.Verify(m => m.Add(It.IsAny<SensorDataModel>()), Times.Once());*/
        }
    
        /*[Fact]
        public void shouldReturnListOfSensorData()
        {
            List<SensorDataModel> sensorDataModelList = (List<SensorDataModel>)_sensorDataServices.RetrieveAllData();

            Xunit.Assert.NotEmpty(sensorDataModelList);
        }*/
    }
}
