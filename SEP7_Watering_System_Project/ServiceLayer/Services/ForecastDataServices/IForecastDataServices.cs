using ServiceLayer.Utility;
using System;
using System.Threading.Tasks;

namespace ServiceLayer.Services.ForecastDataServices
{
    public interface IForecastDataServices
    {
        event EventHandler<ForecastUpdateEvent> _forecastUpdateEvent;
        Task<ForecastDataModel> GetAsync<ForecastDataModel>();
        void StopTimer();
    }
}