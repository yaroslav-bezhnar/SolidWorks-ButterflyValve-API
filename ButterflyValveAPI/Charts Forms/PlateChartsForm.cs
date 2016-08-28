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
    public partial class PlateChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public PlateChartsForm()
        {
            InitializeComponent();
        }

        private void PlateChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.plateCharts.Length / 3; i++)
            {
                chartPlateMass.Series[0].Points.AddY(mainForm.plateCharts[i, 0]);
                chartPlateSquare.Series[0].Points.AddY(mainForm.plateCharts[i, 1]);
                chartPlateVolume.Series[0].Points.AddY(mainForm.plateCharts[i, 2]);
            }
        }
    }
}
