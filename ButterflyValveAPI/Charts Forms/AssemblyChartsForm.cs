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
    public partial class AssemblyChartsForm : Form
    {
        ButterflyValveForm mainForm;
        public AssemblyChartsForm()
        {
            InitializeComponent();
        }

        private void AssemblyChartsForm_Load(object sender, EventArgs e)
        {
            mainForm = this.Owner as ButterflyValveForm;
            for (int i = 0; i < mainForm.assemblyCharts.Length / 3; i++)
            {
                chartAssemblyMass.Series[0].Points.AddY(mainForm.assemblyCharts[i, 0]);
                chartAssemblySquare.Series[0].Points.AddY(mainForm.assemblyCharts[i, 1]);
                chartAssemblyVolume.Series[0].Points.AddY(mainForm.assemblyCharts[i, 2]);
            }
        }
    }
}
