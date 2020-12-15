using DomainLayer.Models.SensorData;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public partial class SensorDataListForm : MaterialForm
    {
        private IEnumerable<ISensorDataModel> _sensorDataList;

        public SensorDataListForm(IEnumerable<ISensorDataModel> sensorDataList)
        {
            InitializeComponent();
            _sensorDataList = sensorDataList;
        }

        private void SensorDataListFrom_Load(object sender, EventArgs e)
        {
            // Populate
            BindingSource source = new BindingSource();
            source.DataSource = _sensorDataList;
        }

        private void SensorDataListFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainView)this.Owner).Enabled = true;
        }
    }
}
