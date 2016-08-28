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
    public partial class BodyChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public BodyChartsForm()
        {
            InitializeComponent();
        }

        private void BodyChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.bodyCharts.Length / 3; i++)
            {
                chartBodyMass.Series[0].Points.AddY(mainForm.bodyCharts[i, 0]);
                chartBodySquare.Series[0].Points.AddY(mainForm.bodyCharts[i, 1]);
                chartBodyVolume.Series[0].Points.AddY(mainForm.bodyCharts[i, 2]);
            }
        }
    }
}
