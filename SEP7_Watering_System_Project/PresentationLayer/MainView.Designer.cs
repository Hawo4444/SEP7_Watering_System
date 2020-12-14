namespace PresentationLayer
{
    partial class MainView
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
            this.groupBoxForecastDays = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDay5 = new System.Windows.Forms.TextBox();
            this.textBoxDay4 = new System.Windows.Forms.TextBox();
            this.textBoxDay3 = new System.Windows.Forms.TextBox();
            this.textBoxDay2 = new System.Windows.Forms.TextBox();
            this.textBoxDay1 = new System.Windows.Forms.TextBox();
            this.groupBoxCurrentSensorData = new System.Windows.Forms.GroupBox();
            this.labelCurrentHumidity = new System.Windows.Forms.Label();
            this.labelCurrentMoisture = new System.Windows.Forms.Label();
            this.labelCurrentTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonWaterNow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.buttonShowSensorData = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBoxForecastDays.SuspendLayout();
            this.groupBoxCurrentSensorData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForecastDays
            // 
            this.groupBoxForecastDays.Controls.Add(this.label6);
            this.groupBoxForecastDays.Controls.Add(this.label5);
            this.groupBoxForecastDays.Controls.Add(this.label4);
            this.groupBoxForecastDays.Controls.Add(this.textBoxDay5);
            this.groupBoxForecastDays.Controls.Add(this.textBoxDay4);
            this.groupBoxForecastDays.Controls.Add(this.textBoxDay3);
            this.groupBoxForecastDays.Controls.Add(this.textBoxDay2);
            this.groupBoxForecastDays.Controls.Add(this.textBoxDay1);
            this.groupBoxForecastDays.Location = new System.Drawing.Point(16, 86);
            this.groupBoxForecastDays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForecastDays.Name = "groupBoxForecastDays";
            this.groupBoxForecastDays.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxForecastDays.Size = new System.Drawing.Size(832, 228);
            this.groupBoxForecastDays.TabIndex = 0;
            this.groupBoxForecastDays.TabStop = false;
            this.groupBoxForecastDays.Text = "Weather Forecast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precipitation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperature:";
            // 
            // textBoxDay5
            // 
            this.textBoxDay5.Location = new System.Drawing.Point(687, 43);
            this.textBoxDay5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay5.Multiline = true;
            this.textBoxDay5.Name = "textBoxDay5";
            this.textBoxDay5.ReadOnly = true;
            this.textBoxDay5.Size = new System.Drawing.Size(132, 137);
            this.textBoxDay5.TabIndex = 4;
            // 
            // textBoxDay4
            // 
            this.textBoxDay4.Location = new System.Drawing.Point(545, 43);
            this.textBoxDay4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay4.Multiline = true;
            this.textBoxDay4.Name = "textBoxDay4";
            this.textBoxDay4.ReadOnly = true;
            this.textBoxDay4.Size = new System.Drawing.Size(132, 137);
            this.textBoxDay4.TabIndex = 3;
            // 
            // textBoxDay3
            // 
            this.textBoxDay3.Location = new System.Drawing.Point(404, 43);
            this.textBoxDay3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay3.Multiline = true;
            this.textBoxDay3.Name = "textBoxDay3";
            this.textBoxDay3.ReadOnly = true;
            this.textBoxDay3.Size = new System.Drawing.Size(132, 137);
            this.textBoxDay3.TabIndex = 2;
            // 
            // textBoxDay2
            // 
            this.textBoxDay2.Location = new System.Drawing.Point(263, 43);
            this.textBoxDay2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay2.Multiline = true;
            this.textBoxDay2.Name = "textBoxDay2";
            this.textBoxDay2.ReadOnly = true;
            this.textBoxDay2.Size = new System.Drawing.Size(132, 137);
            this.textBoxDay2.TabIndex = 2;
            // 
            // textBoxDay1
            // 
            this.textBoxDay1.Location = new System.Drawing.Point(121, 43);
            this.textBoxDay1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay1.Multiline = true;
            this.textBoxDay1.Name = "textBoxDay1";
            this.textBoxDay1.ReadOnly = true;
            this.textBoxDay1.Size = new System.Drawing.Size(132, 137);
            this.textBoxDay1.TabIndex = 1;
            // 
            // groupBoxCurrentSensorData
            // 
            this.groupBoxCurrentSensorData.Controls.Add(this.labelCurrentHumidity);
            this.groupBoxCurrentSensorData.Controls.Add(this.labelCurrentMoisture);
            this.groupBoxCurrentSensorData.Controls.Add(this.labelCurrentTemperature);
            this.groupBoxCurrentSensorData.Controls.Add(this.label3);
            this.groupBoxCurrentSensorData.Controls.Add(this.label2);
            this.groupBoxCurrentSensorData.Controls.Add(this.label1);
            this.groupBoxCurrentSensorData.Location = new System.Drawing.Point(16, 321);
            this.groupBoxCurrentSensorData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCurrentSensorData.Name = "groupBoxCurrentSensorData";
            this.groupBoxCurrentSensorData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCurrentSensorData.Size = new System.Drawing.Size(276, 252);
            this.groupBoxCurrentSensorData.TabIndex = 1;
            this.groupBoxCurrentSensorData.TabStop = false;
            this.groupBoxCurrentSensorData.Text = "Current Sensor Data";
            // 
            // labelCurrentHumidity
            // 
            this.labelCurrentHumidity.AutoSize = true;
            this.labelCurrentHumidity.Location = new System.Drawing.Point(177, 176);
            this.labelCurrentHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentHumidity.Name = "labelCurrentHumidity";
            this.labelCurrentHumidity.Size = new System.Drawing.Size(16, 17);
            this.labelCurrentHumidity.TabIndex = 5;
            this.labelCurrentHumidity.Text = "0";
            // 
            // labelCurrentMoisture
            // 
            this.labelCurrentMoisture.AutoSize = true;
            this.labelCurrentMoisture.Location = new System.Drawing.Point(177, 121);
            this.labelCurrentMoisture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentMoisture.Name = "labelCurrentMoisture";
            this.labelCurrentMoisture.Size = new System.Drawing.Size(16, 17);
            this.labelCurrentMoisture.TabIndex = 4;
            this.labelCurrentMoisture.Text = "0";
            // 
            // labelCurrentTemperature
            // 
            this.labelCurrentTemperature.AutoSize = true;
            this.labelCurrentTemperature.Location = new System.Drawing.Point(177, 69);
            this.labelCurrentTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentTemperature.Name = "labelCurrentTemperature";
            this.labelCurrentTemperature.Size = new System.Drawing.Size(16, 17);
            this.labelCurrentTemperature.TabIndex = 3;
            this.labelCurrentTemperature.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Humidity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moisture:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature:";
            // 
            // buttonWaterNow
            // 
            this.buttonWaterNow.Depth = 0;
            this.buttonWaterNow.Location = new System.Drawing.Point(461, 490);
            this.buttonWaterNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonWaterNow.MaximumSize = new System.Drawing.Size(260, 44);
            this.buttonWaterNow.MinimumSize = new System.Drawing.Size(260, 44);
            this.buttonWaterNow.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonWaterNow.Name = "buttonWaterNow";
            this.buttonWaterNow.Primary = true;
            this.buttonWaterNow.Size = new System.Drawing.Size(260, 44);
            this.buttonWaterNow.TabIndex = 5;
            this.buttonWaterNow.Text = "Water Now";
            this.buttonWaterNow.UseVisualStyleBackColor = true;
            // 
            // buttonShowSensorData
            // 
            this.buttonShowSensorData.AutoSize = true;
            this.buttonShowSensorData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowSensorData.Depth = 0;
            this.buttonShowSensorData.Location = new System.Drawing.Point(461, 433);
            this.buttonShowSensorData.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.buttonShowSensorData.MaximumSize = new System.Drawing.Size(260, 44);
            this.buttonShowSensorData.MinimumSize = new System.Drawing.Size(260, 44);
            this.buttonShowSensorData.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonShowSensorData.Name = "buttonShowSensorData";
            this.buttonShowSensorData.Primary = false;
            this.buttonShowSensorData.Size = new System.Drawing.Size(260, 44);
            this.buttonShowSensorData.TabIndex = 6;
            this.buttonShowSensorData.Text = "Show Watering Schedule";
            this.buttonShowSensorData.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(461, 375);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton1.MaximumSize = new System.Drawing.Size(260, 44);
            this.materialFlatButton1.MinimumSize = new System.Drawing.Size(260, 44);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(260, 44);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Show Past Sensor Data";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.materialFlatButton1_MouseClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 590);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.buttonShowSensorData);
            this.Controls.Add(this.buttonWaterNow);
            this.Controls.Add(this.groupBoxCurrentSensorData);
            this.Controls.Add(this.groupBoxForecastDays);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(864, 590);
            this.MinimumSize = new System.Drawing.Size(864, 590);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Roof System ";
            this.groupBoxForecastDays.ResumeLayout(false);
            this.groupBoxForecastDays.PerformLayout();
            this.groupBoxCurrentSensorData.ResumeLayout(false);
            this.groupBoxCurrentSensorData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxForecastDays;
        private System.Windows.Forms.TextBox textBoxDay1;
        private System.Windows.Forms.TextBox textBoxDay5;
        private System.Windows.Forms.TextBox textBoxDay4;
        private System.Windows.Forms.TextBox textBoxDay3;
        private System.Windows.Forms.TextBox textBoxDay2;
        private System.Windows.Forms.GroupBox groupBoxCurrentSensorData;
        private System.Windows.Forms.Label labelCurrentHumidity;
        private System.Windows.Forms.Label labelCurrentMoisture;
        private System.Windows.Forms.Label labelCurrentTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton buttonWaterNow;
        private MaterialSkin.Controls.MaterialFlatButton buttonShowSensorData;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

