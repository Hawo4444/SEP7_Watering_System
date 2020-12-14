using DomainLayer.Models.ForecastData;
using ServiceLayer.Services.SchedulerServices;
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
        private IMainPresenter _mainPresenter;

        private IWateringSchedulerForecast _wateringScheduler;

        private static Timer apiTimer;
        private const int apiRequestFrequency = 5000; //To be changed

        public ForecastDataServices(IHttpClient apiClient, IMainPresenter mainPresenter, IWateringScheduler wateringScheduler)
        {
            _apiClient = apiClient;
            _mainPresenter = mainPresenter;

            _wateringScheduler = wateringScheduler;

            GetAsync<ForecastDataModel>();
            SetTimer();
        }

        private void SetTimer()
        {
            if(!apiTimer.Enabled)
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
            //be cautious of this line
            _mainPresenter.UpdateForecastData(GetAsync<ForecastDataModel>().Result);
            _wateringScheduler.UpdateForecastDataInScheduler(GetAsync<ForecastDataModel>().Result);
        }

        public Task<ForecastDataModel> GetAsync<ForecastDataModel>()
        {
            return _apiClient.GetAsync<ForecastDataModel>();
        }

        public void StopTimer()
        {
            if (apiTimer.Enabled)
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
