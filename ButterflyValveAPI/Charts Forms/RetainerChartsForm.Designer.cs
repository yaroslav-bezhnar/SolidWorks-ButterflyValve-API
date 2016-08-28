namespace ButterflyValveAPI
{
    partial class RetainerChartsForm
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
            this.groupBoxRetainerChartVolume = new System.Windows.Forms.GroupBox();
            this.chartRetainerVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRetainerMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRetainerChartSquare = new System.Windows.Forms.GroupBox();
            this.chartRetainerSquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRetainerChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxRetainerChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerMass)).BeginInit();
            this.groupBoxRetainerChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerSquare)).BeginInit();
            this.groupBoxRetainerChartMass.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRetainerChartVolume
            // 
            this.groupBoxRetainerChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxRetainerChartVolume.Controls.Add(this.chartRetainerVolume);
            this.groupBoxRetainerChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxRetainerChartVolume.Name = "groupBoxRetainerChartVolume";
            this.groupBoxRetainerChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxRetainerChartVolume.TabIndex = 6;
            this.groupBoxRetainerChartVolume.TabStop = false;
            this.groupBoxRetainerChartVolume.Text = "Об\'єм фіксатора";
            // 
            // chartRetainerVolume
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRetainerVolume.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRetainerVolume.Legends.Add(legend1);
            this.chartRetainerVolume.Location = new System.Drawing.Point(5, 15);
            this.chartRetainerVolume.Name = "chartRetainerVolume";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "volume";
            this.chartRetainerVolume.Series.Add(series1);
            this.chartRetainerVolume.Size = new System.Drawing.Size(340, 280);
            this.chartRetainerVolume.TabIndex = 0;
            this.chartRetainerVolume.Text = "chart1";
            // 
            // chartRetainerMass
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRetainerMass.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRetainerMass.Legends.Add(legend2);
            this.chartRetainerMass.Location = new System.Drawing.Point(5, 15);
            this.chartRetainerMass.Name = "chartRetainerMass";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "mass";
            this.chartRetainerMass.Series.Add(series2);
            this.chartRetainerMass.Size = new System.Drawing.Size(340, 280);
            this.chartRetainerMass.TabIndex = 0;
            this.chartRetainerMass.Text = "chart1";
            // 
            // groupBoxRetainerChartSquare
            // 
            this.groupBoxRetainerChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxRetainerChartSquare.Controls.Add(this.chartRetainerSquare);
            this.groupBoxRetainerChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxRetainerChartSquare.Name = "groupBoxRetainerChartSquare";
            this.groupBoxRetainerChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxRetainerChartSquare.TabIndex = 5;
            this.groupBoxRetainerChartSquare.TabStop = false;
            this.groupBoxRetainerChartSquare.Text = "Площа фіксатора";
            // 
            // chartRetainerSquare
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRetainerSquare.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRetainerSquare.Legends.Add(legend3);
            this.chartRetainerSquare.Location = new System.Drawing.Point(5, 15);
            this.chartRetainerSquare.Name = "chartRetainerSquare";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "square";
            this.chartRetainerSquare.Series.Add(series3);
            this.chartRetainerSquare.Size = new System.Drawing.Size(340, 280);
            this.chartRetainerSquare.TabIndex = 0;
            this.chartRetainerSquare.Text = "chart1";
            // 
            // groupBoxRetainerChartMass
            // 
            this.groupBoxRetainerChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxRetainerChartMass.Controls.Add(this.chartRetainerMass);
            this.groupBoxRetainerChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRetainerChartMass.Name = "groupBoxRetainerChartMass";
            this.groupBoxRetainerChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxRetainerChartMass.TabIndex = 4;
            this.groupBoxRetainerChartMass.TabStop = false;
            this.groupBoxRetainerChartMass.Text = "Маса фіксатора";
            // 
            // RetainerChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxRetainerChartVolume);
            this.Controls.Add(this.groupBoxRetainerChartSquare);
            this.Controls.Add(this.groupBoxRetainerChartMass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "RetainerChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики фіксатора";
            this.Load += new System.EventHandler(this.RetainerChartsForm_Load);
            this.groupBoxRetainerChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerMass)).EndInit();
            this.groupBoxRetainerChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRetainerSquare)).EndInit();
            this.groupBoxRetainerChartMass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRetainerChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRetainerVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRetainerMass;
        private System.Windows.Forms.GroupBox groupBoxRetainerChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRetainerSquare;
        private System.Windows.Forms.GroupBox groupBoxRetainerChartMass;
    }
}