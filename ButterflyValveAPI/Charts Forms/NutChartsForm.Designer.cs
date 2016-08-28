namespace ButterflyValveAPI
{
    partial class NutChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartNutMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNutSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNutChartVolume = new System.Windows.Forms.GroupBox();
            this.chartNutVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxNutChartSquare = new System.Windows.Forms.GroupBox();
            this.groupBoxNutChartMass = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartNutMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNutSquare)).BeginInit();
            this.groupBoxNutChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNutVolume)).BeginInit();
            this.groupBoxNutChartSquare.SuspendLayout();
            this.groupBoxNutChartMass.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartNutMass
            // 
            chartArea1.Name = "ChartArea1";
            this.chartNutMass.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartNutMass.Legends.Add(legend1);
            this.chartNutMass.Location = new System.Drawing.Point(5, 15);
            this.chartNutMass.Name = "chartNutMass";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "mass";
            this.chartNutMass.Series.Add(series1);
            this.chartNutMass.Size = new System.Drawing.Size(340, 280);
            this.chartNutMass.TabIndex = 0;
            this.chartNutMass.Text = "chart1";
            // 
            // chartNutSquare
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNutSquare.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNutSquare.Legends.Add(legend2);
            this.chartNutSquare.Location = new System.Drawing.Point(5, 15);
            this.chartNutSquare.Name = "chartNutSquare";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "square";
            this.chartNutSquare.Series.Add(series2);
            this.chartNutSquare.Size = new System.Drawing.Size(340, 280);
            this.chartNutSquare.TabIndex = 0;
            this.chartNutSquare.Text = "chart1";
            // 
            // groupBoxNutChartVolume
            // 
            this.groupBoxNutChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNutChartVolume.Controls.Add(this.chartNutVolume);
            this.groupBoxNutChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxNutChartVolume.Name = "groupBoxNutChartVolume";
            this.groupBoxNutChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxNutChartVolume.TabIndex = 6;
            this.groupBoxNutChartVolume.TabStop = false;
            this.groupBoxNutChartVolume.Text = "Об\'єм гайки";
            // 
            // chartNutVolume
            // 
            chartArea3.Name = "ChartArea1";
            this.chartNutVolume.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartNutVolume.Legends.Add(legend3);
            this.chartNutVolume.Location = new System.Drawing.Point(5, 15);
            this.chartNutVolume.Name = "chartNutVolume";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "volume";
            this.chartNutVolume.Series.Add(series3);
            this.chartNutVolume.Size = new System.Drawing.Size(340, 280);
            this.chartNutVolume.TabIndex = 0;
            this.chartNutVolume.Text = "chart1";
            // 
            // groupBoxNutChartSquare
            // 
            this.groupBoxNutChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNutChartSquare.Controls.Add(this.chartNutSquare);
            this.groupBoxNutChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxNutChartSquare.Name = "groupBoxNutChartSquare";
            this.groupBoxNutChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxNutChartSquare.TabIndex = 5;
            this.groupBoxNutChartSquare.TabStop = false;
            this.groupBoxNutChartSquare.Text = "Площа гайки";
            // 
            // groupBoxNutChartMass
            // 
            this.groupBoxNutChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNutChartMass.Controls.Add(this.chartNutMass);
            this.groupBoxNutChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxNutChartMass.Name = "groupBoxNutChartMass";
            this.groupBoxNutChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxNutChartMass.TabIndex = 4;
            this.groupBoxNutChartMass.TabStop = false;
            this.groupBoxNutChartMass.Text = "Маса гайки";
            // 
            // NutChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxNutChartVolume);
            this.Controls.Add(this.groupBoxNutChartSquare);
            this.Controls.Add(this.groupBoxNutChartMass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "NutChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики гайки";
            this.Load += new System.EventHandler(this.NutChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartNutMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNutSquare)).EndInit();
            this.groupBoxNutChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNutVolume)).EndInit();
            this.groupBoxNutChartSquare.ResumeLayout(false);
            this.groupBoxNutChartMass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNutMass;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNutSquare;
        private System.Windows.Forms.GroupBox groupBoxNutChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNutVolume;
        private System.Windows.Forms.GroupBox groupBoxNutChartSquare;
        private System.Windows.Forms.GroupBox groupBoxNutChartMass;
    }
}