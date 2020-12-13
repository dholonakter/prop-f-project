namespace ManagerApp
{
    partial class AnalyticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartIncomePerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIncomePerHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartIncomePerType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTicketsPerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTicketsPerDay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartIncomePerDay
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIncomePerDay.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartIncomePerDay.Legends.Add(legend1);
            this.chartIncomePerDay.Location = new System.Drawing.Point(12, 48);
            this.chartIncomePerDay.Name = "chartIncomePerDay";
            this.chartIncomePerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            this.chartIncomePerDay.Series.Add(series1);
            this.chartIncomePerDay.Size = new System.Drawing.Size(429, 263);
            this.chartIncomePerDay.TabIndex = 0;
            this.chartIncomePerDay.Text = "chart1";
            // 
            // chartIncomePerHour
            // 
            chartArea2.Name = "ChartArea1";
            this.chartIncomePerHour.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIncomePerHour.Legends.Add(legend2);
            this.chartIncomePerHour.Location = new System.Drawing.Point(466, 48);
            this.chartIncomePerHour.Name = "chartIncomePerHour";
            this.chartIncomePerHour.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Income";
            this.chartIncomePerHour.Series.Add(series2);
            this.chartIncomePerHour.Size = new System.Drawing.Size(548, 263);
            this.chartIncomePerHour.TabIndex = 1;
            this.chartIncomePerHour.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick 23/05 or 24/05 for data";
            // 
            // chartIncomePerType
            // 
            chartArea3.Name = "ChartArea1";
            this.chartIncomePerType.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIncomePerType.Legends.Add(legend3);
            this.chartIncomePerType.Location = new System.Drawing.Point(12, 329);
            this.chartIncomePerType.Name = "chartIncomePerType";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Income";
            this.chartIncomePerType.Series.Add(series3);
            this.chartIncomePerType.Size = new System.Drawing.Size(429, 263);
            this.chartIncomePerType.TabIndex = 4;
            this.chartIncomePerType.Text = "chart1";
            // 
            // chartTicketsPerDay
            // 
            chartArea4.Name = "ChartArea1";
            this.chartTicketsPerDay.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTicketsPerDay.Legends.Add(legend4);
            this.chartTicketsPerDay.Location = new System.Drawing.Point(466, 329);
            this.chartTicketsPerDay.Name = "chartTicketsPerDay";
            this.chartTicketsPerDay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Income";
            this.chartTicketsPerDay.Series.Add(series4);
            this.chartTicketsPerDay.Size = new System.Drawing.Size(548, 263);
            this.chartTicketsPerDay.TabIndex = 5;
            this.chartTicketsPerDay.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(926, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 3000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // AnalyticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chartTicketsPerDay);
            this.Controls.Add(this.chartIncomePerType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartIncomePerHour);
            this.Controls.Add(this.chartIncomePerDay);
            this.Name = "AnalyticForm";
            this.Text = "AnalyticForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnalyticForm_FormClosed);
            this.Load += new System.EventHandler(this.AnalyticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncomePerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTicketsPerDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerHour;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncomePerType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTicketsPerDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerUpdate;
    }
}