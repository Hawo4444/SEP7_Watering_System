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
            IMainPresenter mainPresenter = new MainPresenter(mainView);

            IArduinoAccess arduinoAccess = new ArduinoAccess();
            IWateringScheduler wateringScheduler = new WateringScheduler(arduinoAccess);

            IHttpClient httpClient = new DefaultHttpClient();
            ForecastDataServices forecastDataServices = new ForecastDataServices(httpClient, mainPresenter, wateringScheduler);

            ISensorDataRepository sensorDataRepository = new SensorDataRepository();
            
            ISensorDataServices sensorDataServices = new SensorDataServices(sensorDataRepository, arduinoAccess, mainPresenter, wateringScheduler);

            //IMainView mainView = mainPresenter.GetMainView();

            Application.Run((MainView)mainView);

            forecastDataServices.StopTimer();
            //sensorDataServices.StopTimer();
        }
    }
}
