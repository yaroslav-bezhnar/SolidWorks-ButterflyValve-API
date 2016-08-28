namespace ButterflyValveAPI
{
    partial class ArmChartsForm
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
            this.chartArmMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxArmChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxArmChartSquare = new System.Windows.Forms.GroupBox();
            this.chartArmSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxArmChartVolume = new System.Windows.Forms.GroupBox();
            this.chartArmVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartArmMass)).BeginInit();
            this.groupBoxArmChartMass.SuspendLayout();
            this.groupBoxArmChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartArmSquare)).BeginInit();
            this.groupBoxArmChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartArmVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // chartArmMass
            // 
            chartArea1.Name = "ChartArea1";
            this.chartArmMass.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartArmMass.Legends.Add(legend1);
            this.chartArmMass.Location = new System.Drawing.Point(5, 15);
            this.chartArmMass.Name = "chartArmMass";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "mass";
            this.chartArmMass.Series.Add(series1);
            this.chartArmMass.Size = new System.Drawing.Size(340, 280);
            this.chartArmMass.TabIndex = 0;
            this.chartArmMass.Text = "chart1";
            // 
            // groupBoxArmChartMass
            // 
            this.groupBoxArmChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxArmChartMass.Controls.Add(this.chartArmMass);
            this.groupBoxArmChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxArmChartMass.Name = "groupBoxArmChartMass";
            this.groupBoxArmChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxArmChartMass.TabIndex = 1;
            this.groupBoxArmChartMass.TabStop = false;
            this.groupBoxArmChartMass.Text = "Маса ручки";
            // 
            // groupBoxArmChartSquare
            // 
            this.groupBoxArmChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxArmChartSquare.Controls.Add(this.chartArmSquare);
            this.groupBoxArmChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxArmChartSquare.Name = "groupBoxArmChartSquare";
            this.groupBoxArmChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxArmChartSquare.TabIndex = 2;
            this.groupBoxArmChartSquare.TabStop = false;
            this.groupBoxArmChartSquare.Text = "Площа ручки";
            // 
            // chartArmSquare
            // 
            chartArea2.Name = "ChartArea1";
            this.chartArmSquare.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartArmSquare.Legends.Add(legend2);
            this.chartArmSquare.Location = new System.Drawing.Point(5, 15);
            this.chartArmSquare.Name = "chartArmSquare";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "square";
            this.chartArmSquare.Series.Add(series2);
            this.chartArmSquare.Size = new System.Drawing.Size(340, 280);
            this.chartArmSquare.TabIndex = 0;
            this.chartArmSquare.Text = "chart1";
            // 
            // groupBoxArmChartVolume
            // 
            this.groupBoxArmChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxArmChartVolume.Controls.Add(this.chartArmVolume);
            this.groupBoxArmChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxArmChartVolume.Name = "groupBoxArmChartVolume";
            this.groupBoxArmChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxArmChartVolume.TabIndex = 3;
            this.groupBoxArmChartVolume.TabStop = false;
            this.groupBoxArmChartVolume.Text = "Об\'єм ручки";
            // 
            // chartArmVolume
            // 
            chartArea3.Name = "ChartArea1";
            this.chartArmVolume.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartArmVolume.Legends.Add(legend3);
            this.chartArmVolume.Location = new System.Drawing.Point(5, 15);
            this.chartArmVolume.Name = "chartArmVolume";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "volume";
            this.chartArmVolume.Series.Add(series3);
            this.chartArmVolume.Size = new System.Drawing.Size(340, 280);
            this.chartArmVolume.TabIndex = 0;
            this.chartArmVolume.Text = "chart1";
            // 
            // ArmChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxArmChartVolume);
            this.Controls.Add(this.groupBoxArmChartSquare);
            this.Controls.Add(this.groupBoxArmChartMass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "ArmChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики ручки";
            this.Load += new System.EventHandler(this.ArmChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartArmMass)).EndInit();
            this.groupBoxArmChartMass.ResumeLayout(false);
            this.groupBoxArmChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartArmSquare)).EndInit();
            this.groupBoxArmChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartArmVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartArmMass;
        private System.Windows.Forms.GroupBox groupBoxArmChartMass;
        private System.Windows.Forms.GroupBox groupBoxArmChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartArmSquare;
        private System.Windows.Forms.GroupBox groupBoxArmChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartArmVolume;
    }
}