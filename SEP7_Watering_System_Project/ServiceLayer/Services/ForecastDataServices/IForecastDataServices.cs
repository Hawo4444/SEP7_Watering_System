using System.Threading.Tasks;

namespace ServiceLayer.Services.ForecastDataServices
{
    public interface IForecastDataServices
    {
        Task<ForecastDataModel> GetAsync<ForecastDataModel>();
        void StopTimer();
    }
}