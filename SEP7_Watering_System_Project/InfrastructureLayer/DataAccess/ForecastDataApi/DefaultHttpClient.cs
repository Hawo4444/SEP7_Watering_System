using Newtonsoft.Json;
using ServiceLayer.Services.ForecastDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.ForecastDataApi
{
    public class DefaultHttpClient : IHttpClient
    {
        const string APPID = "926afdf6c90fe578c9af5b62eb2b43e7";
        private string Units = "metric";
        private double Latitude = 55.86066;
        private double Longitude = 9.85034;

        HttpClient HttpClient;

        public DefaultHttpClient()
        {
            HttpClient = new HttpClient(); 
        }

        public Task<ForecastDataModel> GetAsync<ForecastDataModel>() 
        {
            string uri = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&units={2}&appid={3}&exclude=current,minutely,hourly,alerts", Latitude, Longitude, Units, APPID);
            return GetAsync<ForecastDataModel>(new Uri(uri));
        }

        public async Task<ForecastDataModel> GetAsync<ForecastDataModel>(Uri uri) 
        {
            var Result = default(ForecastDataModel);

            try {
                var Response = await HttpClient.GetAsync(uri).ConfigureAwait(false);
                
                if(Response.Content.Headers.ContentLength.GetValueOrDefault() > 0)
                {
                    string responseBodyAsText = await Response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Result = deserializeJsonToObject<ForecastDataModel>(responseBodyAsText);
                }
            } catch(Exception e) {
                Console.WriteLine(e);
            }
            return Result;
        }

        private static ForecastDataModel deserializeJsonToObject<ForecastDataModel>(string json) 
        {
            var Result = JsonConvert.DeserializeObject<ForecastDataModel>(json);
            return Result;
        }
    }
}
