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
    public partial class ScrewChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public ScrewChartsForm()
        {
            InitializeComponent();
        }

        private void ScrewChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.screwCharts.Length / 3; i++)
            {
                chartScrewMass.Series[0].Points.AddY(mainForm.screwCharts[i, 0]);
                chartScrewSquare.Series[0].Points.AddY(mainForm.screwCharts[i, 1]);
                chartScrewVolume.Series[0].Points.AddY(mainForm.screwCharts[i, 2]);
            }
        }
    }
}
