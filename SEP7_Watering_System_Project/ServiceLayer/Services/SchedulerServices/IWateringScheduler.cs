namespace ServiceLayer.Services.SchedulerServices
{
    public interface IWateringScheduler : IWateringSchedulerForecast, IWateringSchedulerSensors
    {
        void WaterPlants();
        void StopTimer();
    }
}