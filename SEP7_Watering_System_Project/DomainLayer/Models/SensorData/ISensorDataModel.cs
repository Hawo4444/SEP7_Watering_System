using System;

namespace DomainLayer.Models.SensorData
{
    public interface ISensorDataModel
    {
        double Humidity { get; set; }
        double Moisture { get; set; }
        double Temperature { get; set; }
        DateTime TimeStamp { get; set; }
    }
}