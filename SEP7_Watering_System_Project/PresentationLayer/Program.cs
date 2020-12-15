using InfrastructureLayer.DataAccess.EntityFramework.SensorData;
using InfrastructureLayer.DataAccess.ArduinoAccess;
using InfrastructureLayer.DataAccess.ForecastDataApi;
using PresentationLayer.Presenters;
using ServiceLayer.Services.ForecastDataServices;
using ServiceLayer.Services.SensorDataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer.Services.SchedulerServices;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView mainView = new MainView();     

            IArduinoAccess arduinoAccess = new ArduinoAccess();
            IWateringScheduler wateringScheduler = new WateringScheduler(arduinoAccess);

            IHttpClient httpClient = new DefaultHttpClient();
            ForecastDataServices forecastDataServices = new ForecastDataServices(httpClient, wateringScheduler);

            ISensorDataRepository sensorDataRepository = new SensorDataRepository();
            
            ISensorDataServices sensorDataServices = new SensorDataServices(sensorDataRepository, arduinoAccess, wateringScheduler);

            IMainPresenter mainPresenter = new MainPresenter(mainView, wateringScheduler, 
                sensorDataServices, forecastDataServices);

            Application.Run((MainView)mainView);

            forecastDataServices.StopTimer();
            sensorDataServices.StopTimer();
        }
    }
}
