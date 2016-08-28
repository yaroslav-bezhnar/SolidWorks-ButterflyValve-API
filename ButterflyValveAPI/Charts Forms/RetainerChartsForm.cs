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
    public partial class RetainerChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public RetainerChartsForm()
        {
            InitializeComponent();
        }

        private void RetainerChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.retainerCharts.Length / 3; i++)
            {
                chartRetainerMass.Series[0].Points.AddY(mainForm.retainerCharts[i, 0]);
                chartRetainerSquare.Series[0].Points.AddY(mainForm.retainerCharts[i, 1]);
                chartRetainerVolume.Series[0].Points.AddY(mainForm.retainerCharts[i, 2]);
            }
        }
    }
}
