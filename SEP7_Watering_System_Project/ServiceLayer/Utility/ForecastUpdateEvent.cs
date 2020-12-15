using DomainLayer.Models.ForecastData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Utility
{
    public class ForecastUpdateEvent : EventArgs
    {
        public IForecastDataModel _forecastDataModel { get; private set; }

        public ForecastUpdateEvent(IForecastDataModel forecastDataModel)
        {
            _forecastDataModel = forecastDataModel;
        }
    }
}
