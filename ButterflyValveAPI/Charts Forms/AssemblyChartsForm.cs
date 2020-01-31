using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class AssemblyChartsForm : Form
    {
        #region  Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region  Constructors

        public AssemblyChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region  Private Methods

        private void AssemblyChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.assemblyCharts.Length / 3; i++ )
            {
                chartAssemblyMass.Series[0].Points.AddY( _mainForm.assemblyCharts[i, 0] );
                chartAssemblySquare.Series[0].Points.AddY( _mainForm.assemblyCharts[i, 1] );
                chartAssemblyVolume.Series[0].Points.AddY( _mainForm.assemblyCharts[i, 2] );
            }
        }

        #endregion
    }
}