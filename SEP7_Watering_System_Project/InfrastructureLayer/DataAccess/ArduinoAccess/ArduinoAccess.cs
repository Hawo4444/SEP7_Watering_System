using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO.Ports;
using DomainLayer.Models.SensorData;
using ServiceLayer.Services.SensorDataServices;

namespace InfrastructureLayer.DataAccess.ArduinoAccess
{
    public class ArduinoAccess : IArduinoAccess
    {
        private SerialPort port;

        public ArduinoAccess()
        {
            port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = "COM1";
            port.Open();
        }

        public SensorDataModel GetSensorData()
        {
            string s = port.ReadLine();
            Console.WriteLine(s);

            string[] data = s.Split(',');

            double humidity, moisture, temperature;

            double.TryParse(data[0], out humidity);
            double.TryParse(data[1], out moisture);
            double.TryParse(data[2], out temperature);

            DateTime timeNow = DateTime.UtcNow;
            SensorDataModel _sensorData = new SensorDataModel
            {
                TimeStamp = timeNow,
                Humidity = humidity,
                Moisture = moisture,
                Temperature = temperature
            };

            return _sensorData;
        }
    }
}
