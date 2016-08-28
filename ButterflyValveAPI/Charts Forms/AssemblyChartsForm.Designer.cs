namespace ButterflyValveAPI
{
    partial class AssemblyChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxAssemblyChartVolume = new System.Windows.Forms.GroupBox();
            this.chartAssemblyVolume = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAssemblyMass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxAssemblyChartSquare = new System.Windows.Forms.GroupBox();
            this.chartAssemblySquare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxAssemblyChartMass = new System.Windows.Forms.GroupBox();
            this.groupBoxAssemblyChartVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblyVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblyMass)).BeginInit();
            this.groupBoxAssemblyChartSquare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblySquare)).BeginInit();
            this.groupBoxAssemblyChartMass.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAssemblyChartVolume
            // 
            this.groupBoxAssemblyChartVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxAssemblyChartVolume.Controls.Add(this.chartAssemblyVolume);
            this.groupBoxAssemblyChartVolume.Location = new System.Drawing.Point(715, 3);
            this.groupBoxAssemblyChartVolume.Name = "groupBoxAssemblyChartVolume";
            this.groupBoxAssemblyChartVolume.Size = new System.Drawing.Size(350, 300);
            this.groupBoxAssemblyChartVolume.TabIndex = 6;
            this.groupBoxAssemblyChartVolume.TabStop = false;
            this.groupBoxAssemblyChartVolume.Text = "Об\'єм збірки";
            // 
            // chartAssemblyVolume
            // 
            chartArea4.Name = "ChartArea1";
            this.chartAssemblyVolume.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartAssemblyVolume.Legends.Add(legend4);
            this.chartAssemblyVolume.Location = new System.Drawing.Point(5, 15);
            this.chartAssemblyVolume.Name = "chartAssemblyVolume";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Blue;
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "volume";
            this.chartAssemblyVolume.Series.Add(series4);
            this.chartAssemblyVolume.Size = new System.Drawing.Size(340, 280);
            this.chartAssemblyVolume.TabIndex = 0;
            this.chartAssemblyVolume.Text = "chart1";
            // 
            // chartAssemblyMass
            // 
            chartArea5.Name = "ChartArea1";
            this.chartAssemblyMass.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartAssemblyMass.Legends.Add(legend5);
            this.chartAssemblyMass.Location = new System.Drawing.Point(5, 15);
            this.chartAssemblyMass.Name = "chartAssemblyMass";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "mass";
            this.chartAssemblyMass.Series.Add(series5);
            this.chartAssemblyMass.Size = new System.Drawing.Size(340, 280);
            this.chartAssemblyMass.TabIndex = 0;
            this.chartAssemblyMass.Text = "chart1";
            // 
            // groupBoxAssemblyChartSquare
            // 
            this.groupBoxAssemblyChartSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxAssemblyChartSquare.Controls.Add(this.chartAssemblySquare);
            this.groupBoxAssemblyChartSquare.Location = new System.Drawing.Point(359, 3);
            this.groupBoxAssemblyChartSquare.Name = "groupBoxAssemblyChartSquare";
            this.groupBoxAssemblyChartSquare.Size = new System.Drawing.Size(350, 300);
            this.groupBoxAssemblyChartSquare.TabIndex = 5;
            this.groupBoxAssemblyChartSquare.TabStop = false;
            this.groupBoxAssemblyChartSquare.Text = "Площа збірки";
            // 
            // chartAssemblySquare
            // 
            chartArea6.Name = "ChartArea1";
            this.chartAssemblySquare.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartAssemblySquare.Legends.Add(legend6);
            this.chartAssemblySquare.Location = new System.Drawing.Point(5, 15);
            this.chartAssemblySquare.Name = "chartAssemblySquare";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.IsValueShownAsLabel = true;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "square";
            this.chartAssemblySquare.Series.Add(series6);
            this.chartAssemblySquare.Size = new System.Drawing.Size(340, 280);
            this.chartAssemblySquare.TabIndex = 0;
            this.chartAssemblySquare.Text = "chart1";
            // 
            // groupBoxAssemblyChartMass
            // 
            this.groupBoxAssemblyChartMass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxAssemblyChartMass.Controls.Add(this.chartAssemblyMass);
            this.groupBoxAssemblyChartMass.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAssemblyChartMass.Name = "groupBoxAssemblyChartMass";
            this.groupBoxAssemblyChartMass.Size = new System.Drawing.Size(350, 300);
            this.groupBoxAssemblyChartMass.TabIndex = 4;
            this.groupBoxAssemblyChartMass.TabStop = false;
            this.groupBoxAssemblyChartMass.Text = "Маса збірки";
            // 
            // AssemblyChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 311);
            this.Controls.Add(this.groupBoxAssemblyChartVolume);
            this.Controls.Add(this.groupBoxAssemblyChartSquare);
            this.Controls.Add(this.groupBoxAssemblyChartMass);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 350);
            this.MinimumSize = new System.Drawing.Size(1090, 350);
            this.Name = "AssemblyChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Масові характеристики збірки";
            this.Load += new System.EventHandler(this.AssemblyChartsForm_Load);
            this.groupBoxAssemblyChartVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblyVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblyMass)).EndInit();
            this.groupBoxAssemblyChartSquare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAssemblySquare)).EndInit();
            this.groupBoxAssemblyChartMass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssemblyChartVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAssemblyVolume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAssemblyMass;
        private System.Windows.Forms.GroupBox groupBoxAssemblyChartSquare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAssemblySquare;
        private System.Windows.Forms.GroupBox groupBoxAssemblyChartMass;
    }
}