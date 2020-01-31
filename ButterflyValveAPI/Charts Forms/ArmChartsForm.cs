using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class ArmChartsForm : Form
    {
        #region  Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region  Constructors

        public ArmChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region  Private Methods

        private void ArmChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.armCharts.Length / 3; i++ )
            {
                chartArmMass.Series[0].Points.AddY( _mainForm.armCharts[i, 0] );
                chartArmSquare.Series[0].Points.AddY( _mainForm.armCharts[i, 1] );
                chartArmVolume.Series[0].Points.AddY( _mainForm.armCharts[i, 2] );
            }
        }

        #endregion
    }
}