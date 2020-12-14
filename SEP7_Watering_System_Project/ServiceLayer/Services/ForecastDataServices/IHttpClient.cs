using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.ForecastDataServices
{
    public interface IHttpClient
    {
        Task<ForecastDataModel> GetAsync<ForecastDataModel>();
    }
}
