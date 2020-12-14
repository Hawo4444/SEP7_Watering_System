namespace ServiceLayer.Services.SchedulerServices
{
    public interface IWateringScheduler : IWateringSchedulerForecast, IWateringSchedulerSensors
    {
        void StopTimer();
    }
}