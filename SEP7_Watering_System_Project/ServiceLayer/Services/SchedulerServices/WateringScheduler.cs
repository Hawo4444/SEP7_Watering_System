using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;
using ServiceLayer.Services.SensorDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceLayer.Services.SchedulerServices
{
    public class WateringScheduler : IWateringScheduler
    {
        private IArduinoAccessScheduler _arduinoAccess;

        private static Timer wateringTimer;

        // Should be adjusted according to the type of plants used
        private const int daysPlantsCanSurviveWithoutWater = 20;
        // When amount of water in soil is under the threshold, start counting days without water
        private const double soilMoistureThreshold = 450;
        // Number of days currently forecasted, used for determining whether the system should water (if there is no rain in those days) 
        private const int numberOfDaysForecasted = 5;
        // Keeps track of how much rain there should be durin the forecasted period
        private double amountOfRainWithinForecastedPeriod = 0;
        /* Checked to the timer when setting, keeps track on whether there was supposed to be rain during the 
        daysPlantsCanSurviveWithoutWater - numberOfDaysForecasted period to start the right timer */
        private bool isCloseToMaxSurvival = false;
        // Last recorded soil moisture
        private double lastRecorderSoilMoisture;

        public WateringScheduler(IArduinoAccessScheduler arduinoAccess)
        {
            _arduinoAccess = arduinoAccess;
        }

        // Checks whether the plants are close to daysPlantsCanSurviveWithoutWater
        private void AdjustTimer()
        {
            int time = 0;
            // If yes, start timer for numberOfDaysForecasted
            if (isCloseToMaxSurvival)
            {
                time = (numberOfDaysForecasted * 86400);
                SetTimer(time);               
            }
            // If not, start timer for daysPlantsCanSurviveWithoutWater - numberOfDaysForecasted
            else
            {
                time = ((daysPlantsCanSurviveWithoutWater - numberOfDaysForecasted) * 86400); // Days to seconds
                SetTimer(time);
            }  
        }

        private void SetTimer(int time)
        {
            if (wateringTimer == null)
            {
                // Create a timer with an interval
                wateringTimer = new Timer(time); // Days to seconds
                // Hook up the Elapsed event for the timer 
                wateringTimer.Elapsed += OnTimedEvent;
                wateringTimer.AutoReset = false;
                wateringTimer.Enabled = true;
            }
        }

        public void StopTimer()
        {
            if (!(wateringTimer == null))
            {
                wateringTimer.Enabled = false;
                wateringTimer.Stop();
                wateringTimer.Dispose();
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // If true -> the plants were about to die, therefore 
            if(isCloseToMaxSurvival)
            {
                // Last recorded moisture was lower than the threshold -> water plants
                if(lastRecorderSoilMoisture < soilMoistureThreshold)
                {
                    Water();    
                }   
                isCloseToMaxSurvival = false;
            } 
            else
            {
                // Figure out whether it rains within the next 5 days
                if (amountOfRainWithinForecastedPeriod > 1) // Could be changed to a certain threshold for rain
                {
                    isCloseToMaxSurvival = true;
                }
                else
                {
                    Water();
                }
            }
        }

        public void UpdateForecastDataInScheduler(IForecastDataModel forecastDataModel)
        {
            // Update forecast data
            amountOfRainWithinForecastedPeriod = 0;
            for (int i = 0; i < numberOfDaysForecasted; i++)
            {
                // Probability of rain * amount of rain for each day to account for the probability
                amountOfRainWithinForecastedPeriod += (forecastDataModel.Daily[i].Rain * (forecastDataModel.Daily[i].Pop / 100));
            }
        }

        public void UpdateSensorDataInScheduler(ISensorDataModel sensorDataModel)
        {
            lastRecorderSoilMoisture = sensorDataModel.Moisture;
            // Update sensor data
            if (lastRecorderSoilMoisture < soilMoistureThreshold)
            {              
                AdjustTimer();              
            }
            else 
            {     
                StopTimer();
            }
        }

        public void Water()
        {
            _arduinoAccess.Water();
        }
    }
}
