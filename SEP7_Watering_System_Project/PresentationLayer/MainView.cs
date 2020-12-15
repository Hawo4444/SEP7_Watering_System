using DomainLayer.Models.ForecastData;
using DomainLayer.Models.SensorData;
using MaterialSkin;
using MaterialSkin.Controls;
using PresentationLayer.Utility;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainView : MaterialForm, IMainView
    {
        private delegate void SafeCallDelegate(string text, dynamic control);

        public event EventHandler<EventClass> ViewEvent = (s, e) => { };

        public MainView()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightGreen100, TextShade.WHITE);
            //this.Show();
        }

        public void ShowMainView()
        {
            this.Show();
        }

        public void UpdateForecastData(IForecastDataModel forecastDataModel)
        {
            WriteTextSafe(ProcessForecastDay(forecastDataModel.Daily[0]), textBoxDay1);
            WriteTextSafe(ProcessForecastDay(forecastDataModel.Daily[1]), textBoxDay2);
            WriteTextSafe(ProcessForecastDay(forecastDataModel.Daily[2]), textBoxDay3);
            WriteTextSafe(ProcessForecastDay(forecastDataModel.Daily[3]), textBoxDay4);
            WriteTextSafe(ProcessForecastDay(forecastDataModel.Daily[4]), textBoxDay5);
        }

        private string ProcessForecastDay(Daily day)
        {
            return UnixToDateConverter.GetDay(day.Dt) + "\r\n" +
                UnixToDateConverter.GetDate(day.Dt).ToString("dd/MM/yyyy") + "\r\n\r\n" +
                day.Temp.Day + "°C\r\n\r\n" +
                day.Humidity + "%\r\n\r\n" +
                day.Rain + " mm";
        }

        private void WriteTextSafe(string text, dynamic control) 
        {
            if (control.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                control.Invoke(d, new object[] { text, control });
            }
            else
            {
                control.Text = text;
            }
        }

        public void UpdateCurrentSensorData(ISensorDataModel sensorDataModel)
        {
            WriteTextSafe(sensorDataModel.Temperature.ToString(), labelCurrentTemperature);
            WriteTextSafe(sensorDataModel.Moisture.ToString(), labelCurrentMoisture);
            WriteTextSafe(sensorDataModel.Humidity.ToString(), labelCurrentHumidity);
        }

        private void materialFlatButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Enabled = false;
            new SensorDataListForm().Show(this);
        }

        private void waterPlantsManually(object sender, EventArgs e)
        {
            ViewEvent(this, new EventClass("ShowAllData"));
        }
    }
}
