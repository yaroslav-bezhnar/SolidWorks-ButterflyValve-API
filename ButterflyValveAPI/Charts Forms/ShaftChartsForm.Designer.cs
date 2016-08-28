namespace ButterflyValveAPI
{
    partial class ShaftChartsForm
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
            this.chartShaftMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxShaftChartSquare = new System.Windows.Forms.GroupBox();
            this.chartShaftSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxShaftChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxShaftChartVolume = new System.Windows.Forms.GroupBox();
            this.chartShaftVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftMass)).BeginInit();
            this.groupBoxShaftChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftSquare)).BeginInit();
            this.groupBoxShaftChartMass.SuspendLayout();
            this.groupBoxShaftChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // chartShaftMass
            // 
            chartArea1.Name = "ChartArea1";
            this.chartShaftMass.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartShaftMass.Legends.Add(legend1);
            this.chartShaftMass.Location = new System.Drawing.Point(5, 15);
            this.chartShaftMass.Name = "chartShaftMass";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "mass";
            this.chartShaftMass.Series.Add(series1);
            this.chartShaftMass.Size = new System.Drawing.Size(340, 280);
            this.chartShaftMass.TabIndex = 0;
            this.chartShaftMass.Text = "chart1";
            // 
            // groupBoxShaftChartSquare
            // 
            this.groupBoxShaftChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxShaftChartSquare.Controls.Add(this.chartShaftSquare);
            this.groupBoxShaftChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxShaftChartSquare.Name = "groupBoxShaftChartSquare";
            this.groupBoxShaftChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxShaftChartSquare.TabIndex = 5;
            this.groupBoxShaftChartSquare.TabStop = false;
            this.groupBoxShaftChartSquare.Text = "Площа вала";
            // 
            // chartShaftSquare
            // 
            chartArea2.Name = "ChartArea1";
            this.chartShaftSquare.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartShaftSquare.Legends.Add(legend2);
            this.chartShaftSquare.Location = new System.Drawing.Point(5, 15);
            this.chartShaftSquare.Name = "chartShaftSquare";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "square";
            this.chartShaftSquare.Series.Add(series2);
            this.chartShaftSquare.Size = new System.Drawing.Size(340, 280);
            this.chartShaftSquare.TabIndex = 0;
            this.chartShaftSquare.Text = "chart1";
            // 
            // groupBoxShaftChartMass
            // 
            this.groupBoxShaftChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxShaftChartMass.Controls.Add(this.chartShaftMass);
            this.groupBoxShaftChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxShaftChartMass.Name = "groupBoxShaftChartMass";
            this.groupBoxShaftChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxShaftChartMass.TabIndex = 4;
            this.groupBoxShaftChartMass.TabStop = false;
            this.groupBoxShaftChartMass.Text = "Маса вала";
            // 
            // groupBoxShaftChartVolume
            // 
            this.groupBoxShaftChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxShaftChartVolume.Controls.Add(this.chartShaftVolume);
            this.groupBoxShaftChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxShaftChartVolume.Name = "groupBoxShaftChartVolume";
            this.groupBoxShaftChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxShaftChartVolume.TabIndex = 6;
            this.groupBoxShaftChartVolume.TabStop = false;
            this.groupBoxShaftChartVolume.Text = "Об\'єм вала";
            // 
            // chartShaftVolume
            // 
            chartArea3.Name = "ChartArea1";
            this.chartShaftVolume.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartShaftVolume.Legends.Add(legend3);
            this.chartShaftVolume.Location = new System.Drawing.Point(5, 15);
            this.chartShaftVolume.Name = "chartShaftVolume";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "volume";
            this.chartShaftVolume.Series.Add(series3);
            this.chartShaftVolume.Size = new System.Drawing.Size(340, 280);
            this.chartShaftVolume.TabIndex = 0;
            this.chartShaftVolume.Text = "chart1";
            // 
            // ShaftChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxShaftChartSquare);
            this.Controls.Add(this.groupBoxShaftChartMass);
            this.Controls.Add(this.groupBoxShaftChartVolume);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "ShaftChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики вала";
            this.Load += new System.EventHandler(this.ShaftChartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftMass)).EndInit();
            this.groupBoxShaftChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftSquare)).EndInit();
            this.groupBoxShaftChartMass.ResumeLayout(false);
            this.groupBoxShaftChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartShaftVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartShaftMass;
        private System.Windows.Forms.GroupBox groupBoxShaftChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShaftSquare;
        private System.Windows.Forms.GroupBox groupBoxShaftChartMass;
        private System.Windows.Forms.GroupBox groupBoxShaftChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShaftVolume;
    }
}