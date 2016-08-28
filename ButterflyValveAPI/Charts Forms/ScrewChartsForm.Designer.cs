namespace ButterflyValveAPI
{
    partial class ScrewChartsForm
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
            this.groupBoxScrewChartSquare = new System.Windows.Forms.GroupBox();
            this.chartScrewSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartScrewMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxScrewChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxScrewChartVolume = new System.Windows.Forms.GroupBox();
            this.chartScrewVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxScrewChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewMass)).BeginInit();
            this.groupBoxScrewChartMass.SuspendLayout();
            this.groupBoxScrewChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxScrewChartSquare
            // 
            this.groupBoxScrewChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxScrewChartSquare.Controls.Add(this.chartScrewSquare);
            this.groupBoxScrewChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxScrewChartSquare.Name = "groupBoxScrewChartSquare";
            this.groupBoxScrewChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxScrewChartSquare.TabIndex = 5;
            this.groupBoxScrewChartSquare.TabStop = false;
            this.groupBoxScrewChartSquare.Text = "Площа гвинта";
            // 
            // chartScrewSquare
            // 
            chartArea1.Name = "ChartArea1";
            this.chartScrewSquare.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartScrewSquare.Legends.Add(legend1);
            this.chartScrewSquare.Location = new System.Drawing.Point(5, 15);
            this.chartScrewSquare.Name = "chartScrewSquare";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "square";
            this.chartScrewSquare.Series.Add(series1);
            this.chartScrewSquare.Size = new System.Drawing.Size(340, 280);
            this.chartScrewSquare.TabIndex = 0;
            this.chartScrewSquare.Text = "chart1";
            // 
            // chartScrewMass
            // 
            chartArea2.Name = "ChartArea1";
            this.chartScrewMass.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartScrewMass.Legends.Add(legend2);
            this.chartScrewMass.Location = new System.Drawing.Point(5, 15);
            this.chartScrewMass.Name = "chartScrewMass";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "mass";
            this.chartScrewMass.Series.Add(series2);
            this.chartScrewMass.Size = new System.Drawing.Size(340, 280);
            this.chartScrewMass.TabIndex = 0;
            this.chartScrewMass.Text = "chart1";
            // 
            // groupBoxScrewChartMass
            // 
            this.groupBoxScrewChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxScrewChartMass.Controls.Add(this.chartScrewMass);
            this.groupBoxScrewChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxScrewChartMass.Name = "groupBoxScrewChartMass";
            this.groupBoxScrewChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxScrewChartMass.TabIndex = 4;
            this.groupBoxScrewChartMass.TabStop = false;
            this.groupBoxScrewChartMass.Text = "Маса гвинта";
            // 
            // groupBoxScrewChartVolume
            // 
            this.groupBoxScrewChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxScrewChartVolume.Controls.Add(this.chartScrewVolume);
            this.groupBoxScrewChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxScrewChartVolume.Name = "groupBoxScrewChartVolume";
            this.groupBoxScrewChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxScrewChartVolume.TabIndex = 6;
            this.groupBoxScrewChartVolume.TabStop = false;
            this.groupBoxScrewChartVolume.Text = "Об\'єм гвинта";
            // 
            // chartScrewVolume
            // 
            chartArea3.Name = "ChartArea1";
            this.chartScrewVolume.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartScrewVolume.Legends.Add(legend3);
            this.chartScrewVolume.Location = new System.Drawing.Point(5, 15);
            this.chartScrewVolume.Name = "chartScrewVolume";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "volume";
            this.chartScrewVolume.Series.Add(series3);
            this.chartScrewVolume.Size = new System.Drawing.Size(340, 280);
            this.chartScrewVolume.TabIndex = 0;
            this.chartScrewVolume.Text = "chart1";
            // 
            // ScrewChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxScrewChartSquare);
            this.Controls.Add(this.groupBoxScrewChartMass);
            this.Controls.Add(this.groupBoxScrewChartVolume);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "ScrewChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики гвинта";
            this.Load += new System.EventHandler(this.ScrewChartsForm_Load);
            this.groupBoxScrewChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewMass)).EndInit();
            this.groupBoxScrewChartMass.ResumeLayout(false);
            this.groupBoxScrewChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartScrewVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxScrewChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScrewSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScrewMass;
        private System.Windows.Forms.GroupBox groupBoxScrewChartMass;
        private System.Windows.Forms.GroupBox groupBoxScrewChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartScrewVolume;
    }
}