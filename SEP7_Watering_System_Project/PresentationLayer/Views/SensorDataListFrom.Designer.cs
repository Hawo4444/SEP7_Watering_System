namespace PresentationLayer.Views
{
    partial class SensorDataListFrom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet = new PresentationLayer._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet();
            this.observationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observationsTableAdapter = new PresentationLayer._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSetTableAdapters.ObservationsTableAdapter();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moistureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationsBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.observationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // _WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet
            // 
            this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet.DataSetName = "_WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet";
            this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // observationsBindingSource
            // 
            this.observationsBindingSource.DataMember = "Observations";
            this.observationsBindingSource.DataSource = this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet;
            // 
            // observationsTableAdapter
            // 
            this.observationsTableAdapter.ClearBeforeFill = true;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.timeStampDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Width = 150;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.ReadOnly = true;
            this.humidityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // moistureDataGridViewTextBoxColumn
            // 
            this.moistureDataGridViewTextBoxColumn.DataPropertyName = "Moisture";
            this.moistureDataGridViewTextBoxColumn.HeaderText = "Moisture";
            this.moistureDataGridViewTextBoxColumn.Name = "moistureDataGridViewTextBoxColumn";
            this.moistureDataGridViewTextBoxColumn.ReadOnly = true;
            this.moistureDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SensorDataListFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 400);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(519, 400);
            this.MinimumSize = new System.Drawing.Size(519, 400);
            this.Name = "SensorDataListFrom";
            this.Text = "Past Sensor Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SensorDataListFrom_FormClosing);
            this.Load += new System.EventHandler(this.SensorDataListFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.observationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet _WindowsFormsApp1_SensorsDB_ByConnectionStringDataSet;
        private System.Windows.Forms.BindingSource observationsBindingSource;
        private _WindowsFormsApp1_SensorsDB_ByConnectionStringDataSetTableAdapters.ObservationsTableAdapter observationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moistureDataGridViewTextBoxColumn;
    }
}