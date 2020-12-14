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
    public partial class SensorDataListFrom : MaterialForm
    {
        public SensorDataListFrom()
        {
            InitializeComponent();
        }

        private void SensorDataListFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet.Observations' table. You can move, or remove it, as needed.
            this.observationsTableAdapter.Fill(this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet.Observations);

        }

        private void SensorDataListFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainView)this.Owner).Enabled = true;
        }
    }
}
