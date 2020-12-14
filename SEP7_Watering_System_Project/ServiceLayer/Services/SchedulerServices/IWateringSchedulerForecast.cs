using DomainLayer.Models.ForecastData;

namespace ServiceLayer.Services.SchedulerServices
{
    public interface IWateringSchedulerForecast
    {
        void UpdateForecastDataInScheduler(IForecastDataModel forecastDataModel);
    }
}