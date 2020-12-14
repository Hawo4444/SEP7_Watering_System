using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.ForecastData
{
    public class ForecastDataModel : IForecastDataModel
    {
        public List<Daily> Daily { get; set; }
    }

    public class Temp
    { 
        public double Day { get; set; }
    }

    public class Daily
    {
        public int Dt { get; set; }
        public Temp Temp { get; set; }
        public int Humidity { get; set; }
        public double Pop { get; set; }
        public double Rain { get; set; }
    }  
}
