namespace PresentationLayer.Views
{
    partial class SensorDataListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorDataModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moistureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeStampDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.moistureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sensorDataModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(418, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // sensorDataModelBindingSource
            // 
            this.sensorDataModelBindingSource.DataSource = typeof(DomainLayer.Models.SensorData.SensorDataModel);
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moistureDataGridViewTextBoxColumn
            // 
            this.moistureDataGridViewTextBoxColumn.DataPropertyName = "Moisture";
            this.moistureDataGridViewTextBoxColumn.HeaderText = "Moisture";
            this.moistureDataGridViewTextBoxColumn.Name = "moistureDataGridViewTextBoxColumn";
            this.moistureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SensorDataListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(600, 650);
            this.MinimumSize = new System.Drawing.Size(600, 406);
            this.Name = "SensorDataListForm";
            this.Text = "Past Sensor Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SensorDataListFrom_FormClosing);
            this.Load += new System.EventHandler(this.SensorDataListFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorDataModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moistureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sensorDataModelBindingSource;
    }
}