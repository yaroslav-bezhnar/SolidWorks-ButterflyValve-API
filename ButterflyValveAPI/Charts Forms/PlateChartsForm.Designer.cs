namespace ButterflyValveAPI
{
    partial class PlateChartsForm
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
            this.chartPlateMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPlateChartSquare = new System.Windows.Forms.GroupBox();
            this.chartPlateSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxPlateChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxPlateChartVolume = new System.Windows.Forms.GroupBox();
            this.chartPlateVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateMass)).BeginInit();
            this.groupBoxPlateChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateSquare)).BeginInit();
            this.groupBoxPlateChartMass.SuspendLayout();
            this.groupBoxPlateChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPlateMass
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPlateMass.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPlateMass.Legends.Add(legend1);
            this.chartPlateMass.Location = new System.Drawing.Point(5, 15);
            this.chartPlateMass.Name = "chartPlateMass";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "mass";
            this.chartPlateMass.Series.Add(series1);
            this.chartPlateMass.Size = new System.Drawing.Size(340, 280);
            this.chartPlateMass.TabIndex = 0;
            this.chartPlateMass.Text = "chart1";
            // 
            // groupBoxPlateChartSquare
            // 
            this.groupBoxPlateChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxPlateChartSquare.Controls.Add(this.chartPlateSquare);
            this.groupBoxPlateChartSquare.Location = new System.Drawing.Point(362, 5);
            this.groupBoxPlateChartSquare.Name = "groupBoxPlateChartSquare";
            this.groupBoxPlateChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxPlateChartSquare.TabIndex = 5;
            this.groupBoxPlateChartSquare.TabStop = false;
            this.groupBoxPlateChartSquare.Text = "Площа пластини";
            // 
            // chartPlateSquare
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPlateSquare.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPlateSquare.Legends.Add(legend2);
            this.chartPlateSquare.Location = new System.Drawing.Point(5, 15);
            this.chartPlateSquare.Name = "chartPlateSquare";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "square";
            this.chartPlateSquare.Series.Add(series2);
            this.chartPlateSquare.Size = new System.Drawing.Size(340, 280);
            this.chartPlateSquare.TabIndex = 0;
            this.chartPlateSquare.Text = "chart1";
            // 
            // groupBoxPlateChartMass
            // 
            this.groupBoxPlateChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxPlateChartMass.Controls.Add(this.chartPlateMass);
            this.groupBoxPlateChartMass.Location = new System.Drawing.Point(6, 5);
            this.groupBoxPlateChartMass.Name = "groupBoxPlateChartMass";
            this.groupBoxPlateChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxPlateChartMass.TabIndex = 4;
            this.groupBoxPlateChartMass.TabStop = false;
            this.groupBoxPlateChartMass.Text = "Маса пластини";
            // 
            // groupBoxPlateChartVolume
            // 
            this.groupBoxPlateChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxPlateChartVolume.Controls.Add(this.chartPlateVolume);
            this.groupBoxPlateChartVolume.Location = new System.Drawing.Point(718, 5);
            this.groupBoxPlateChartVolume.Name = "groupBoxPlateChartVolume";
            this.groupBoxPlateChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxPlateChartVolume.TabIndex = 6;
            this.groupBoxPlateChartVolume.TabStop = false;
            this.groupBoxPlateChartVolume.Text = "Об\'єм пластини";
            // 
            // chartPlateVolume
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPlateVolume.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPlateVolume.Legends.Add(legend3);
            this.chartPlateVolume.Location = new System.Drawing.Point(5, 15);
            this.chartPlateVolume.Name = "chartPlateVolume";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "volume";
            this.chartPlateVolume.Series.Add(series3);
            this.chartPlateVolume.Size = new System.Drawing.Size(340, 280);
            this.chartPlateVolume.TabIndex = 0;
            this.chartPlateVolume.Text = "chart1";
            // 
            // PlateChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxPlateChartSquare);
            this.Controls.Add(this.groupBoxPlateChartMass);
            this.Controls.Add(this.groupBoxPlateChartVolume);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "PlateChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики пластини";
            this.Load += new System.EventHandler(this.PlateChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateMass)).EndInit();
            this.groupBoxPlateChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateSquare)).EndInit();
            this.groupBoxPlateChartMass.ResumeLayout(false);
            this.groupBoxPlateChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPlateVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlateMass;
        private System.Windows.Forms.GroupBox groupBoxPlateChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlateSquare;
        private System.Windows.Forms.GroupBox groupBoxPlateChartMass;
        private System.Windows.Forms.GroupBox groupBoxPlateChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlateVolume;

    }
}