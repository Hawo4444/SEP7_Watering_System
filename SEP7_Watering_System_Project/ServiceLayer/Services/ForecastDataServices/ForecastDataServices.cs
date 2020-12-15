using DomainLayer.Models.ForecastData;
using ServiceLayer.Services.SchedulerServices;
using ServiceLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceLayer.Services.ForecastDataServices
{
    public class ForecastDataServices : IHttpClient, IForecastDataServices, IWateringSchedulerForecast
    {
        private IHttpClient _apiClient;
        private IWateringSchedulerForecast _wateringScheduler;

        public event EventHandler<ForecastUpdateEvent> _forecastUpdateEvent = (s, e) => { };

        private static Timer apiTimer;
        private const int apiRequestFrequency = 3600; // Update weather data every hour 

        public ForecastDataServices(IHttpClient apiClient, IWateringScheduler wateringScheduler)
        {
            _apiClient = apiClient;

            _wateringScheduler = wateringScheduler;

            GetAsync<ForecastDataModel>();
            SetTimer();
        }

        private void SetTimer()
        {
            if(apiTimer == null)
            {
                // Create a timer with an interval.
                apiTimer = new Timer(apiRequestFrequency); 
                // Hook up the Elapsed event for the timer. 
                apiTimer.Elapsed += OnTimedEvent;
                apiTimer.AutoReset = true;
                apiTimer.Enabled = true;
            }           
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _forecastUpdateEvent(this, new ForecastUpdateEvent(GetAsync<ForecastDataModel>().Result));
            _wateringScheduler.UpdateForecastDataInScheduler(GetAsync<ForecastDataModel>().Result);
        }

        public Task<ForecastDataModel> GetAsync<ForecastDataModel>()
        {
            return _apiClient.GetAsync<ForecastDataModel>();
        }

        public void StopTimer()
        {
            if (!(apiTimer == null))
            {
                apiTimer.Enabled = false;
                apiTimer.Stop();
                apiTimer.Dispose();
            }
        }

        public void UpdateForecastDataInScheduler(IForecastDataModel forecastDataModel)
        {
            _wateringScheduler.UpdateForecastDataInScheduler(forecastDataModel);
        }
    }
}
