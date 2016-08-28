using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class NutChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public NutChartsForm()
        {
            InitializeComponent();
        }

        private void NutChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.nutCharts.Length / 3; i++)
            {
                chartNutMass.Series[0].Points.AddY(mainForm.nutCharts[i, 0]);
                chartNutSquare.Series[0].Points.AddY(mainForm.nutCharts[i, 1]);
                chartNutVolume.Series[0].Points.AddY(mainForm.nutCharts[i, 2]);
            }
        }
    }
}
