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
    public partial class ArmChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public ArmChartsForm()
        {
            InitializeComponent();
        }

        private void ArmChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.armCharts.Length / 3; i++)
            {
                chartArmMass.Series[0].Points.AddY(mainForm.armCharts[i, 0]);
                chartArmSquare.Series[0].Points.AddY(mainForm.armCharts[i, 1]);
                chartArmVolume.Series[0].Points.AddY(mainForm.armCharts[i, 2]);
            }
        }
    }
}
