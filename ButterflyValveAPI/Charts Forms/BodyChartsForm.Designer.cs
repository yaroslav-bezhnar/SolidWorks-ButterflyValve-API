namespace ButterflyValveAPI
{
    partial class BodyChartsForm
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
            this.groupBoxBodyChartVolume = new System.Windows.Forms.GroupBox();
            this.chartBodyVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBodyMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxBodyChartSquare = new System.Windows.Forms.GroupBox();
            this.chartBodySquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxBodyChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxBodyChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBodyVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBodyMass)).BeginInit();
            this.groupBoxBodyChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBodySquare)).BeginInit();
            this.groupBoxBodyChartMass.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBodyChartVolume
            // 
            this.groupBoxBodyChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBodyChartVolume.Controls.Add(this.chartBodyVolume);
            this.groupBoxBodyChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxBodyChartVolume.Name = "groupBoxBodyChartVolume";
            this.groupBoxBodyChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxBodyChartVolume.TabIndex = 6;
            this.groupBoxBodyChartVolume.TabStop = false;
            this.groupBoxBodyChartVolume.Text = "Об\'єм корпуса";
            // 
            // chartBodyVolume
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBodyVolume.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBodyVolume.Legends.Add(legend1);
            this.chartBodyVolume.Location = new System.Drawing.Point(5, 15);
            this.chartBodyVolume.Name = "chartBodyVolume";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "volume";
            this.chartBodyVolume.Series.Add(series1);
            this.chartBodyVolume.Size = new System.Drawing.Size(340, 280);
            this.chartBodyVolume.TabIndex = 0;
            this.chartBodyVolume.Text = "chart1";
            // 
            // chartBodyMass
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBodyMass.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBodyMass.Legends.Add(legend2);
            this.chartBodyMass.Location = new System.Drawing.Point(5, 15);
            this.chartBodyMass.Name = "chartBodyMass";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "mass";
            this.chartBodyMass.Series.Add(series2);
            this.chartBodyMass.Size = new System.Drawing.Size(340, 280);
            this.chartBodyMass.TabIndex = 0;
            this.chartBodyMass.Text = "chart1";
            // 
            // groupBoxBodyChartSquare
            // 
            this.groupBoxBodyChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBodyChartSquare.Controls.Add(this.chartBodySquare);
            this.groupBoxBodyChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxBodyChartSquare.Name = "groupBoxBodyChartSquare";
            this.groupBoxBodyChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxBodyChartSquare.TabIndex = 5;
            this.groupBoxBodyChartSquare.TabStop = false;
            this.groupBoxBodyChartSquare.Text = "Площа корпуса";
            // 
            // chartBodySquare
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBodySquare.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBodySquare.Legends.Add(legend3);
            this.chartBodySquare.Location = new System.Drawing.Point(5, 15);
            this.chartBodySquare.Name = "chartBodySquare";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "square";
            this.chartBodySquare.Series.Add(series3);
            this.chartBodySquare.Size = new System.Drawing.Size(340, 280);
            this.chartBodySquare.TabIndex = 0;
            this.chartBodySquare.Text = "chart1";
            // 
            // groupBoxBodyChartMass
            // 
            this.groupBoxBodyChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxBodyChartMass.Controls.Add(this.chartBodyMass);
            this.groupBoxBodyChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBodyChartMass.Name = "groupBoxBodyChartMass";
            this.groupBoxBodyChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxBodyChartMass.TabIndex = 4;
            this.groupBoxBodyChartMass.TabStop = false;
            this.groupBoxBodyChartMass.Text = "Маса корпуса";
            // 
            // BodyChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxBodyChartVolume);
            this.Controls.Add(this.groupBoxBodyChartSquare);
            this.Controls.Add(this.groupBoxBodyChartMass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "BodyChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики корпуса";
            this.Load += new System.EventHandler(this.BodyChartsForm_Load);
            this.groupBoxBodyChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBodyVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBodyMass)).EndInit();
            this.groupBoxBodyChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBodySquare)).EndInit();
            this.groupBoxBodyChartMass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBodyChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBodyVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBodyMass;
        private System.Windows.Forms.GroupBox groupBoxBodyChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBodySquare;
        private System.Windows.Forms.GroupBox groupBoxBodyChartMass;
    }
}