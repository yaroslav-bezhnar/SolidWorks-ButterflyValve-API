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
    public partial class ShaftChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public ShaftChartsForm()
        {
            InitializeComponent();
        }

        private void ShaftChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.shaftCharts.Length / 3; i++)
            {
                chartShaftMass.Series[0].Points.AddY(mainForm.shaftCharts[i, 0]);
                chartShaftSquare.Series[0].Points.AddY(mainForm.shaftCharts[i, 1]);
                chartShaftVolume.Series[0].Points.AddY(mainForm.shaftCharts[i, 2]);
            }
        }
    }
}
