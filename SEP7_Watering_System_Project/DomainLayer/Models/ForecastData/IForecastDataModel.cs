using System.Collections.Generic;

namespace DomainLayer.Models.ForecastData
{
    public interface IForecastDataModel
    {
        List<Daily> Daily { get; set; }
    }
}