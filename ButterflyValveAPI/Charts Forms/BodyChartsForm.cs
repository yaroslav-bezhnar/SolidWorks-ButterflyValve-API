using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class BodyChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public BodyChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region  Private Methods

        private void BodyChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.bodyCharts.Length / 3; i++ )
            {
                chartBodyMass.Series[0].Points.AddY( _mainForm.bodyCharts[i, 0] );
                chartBodySquare.Series[0].Points.AddY( _mainForm.bodyCharts[i, 1] );
                chartBodyVolume.Series[0].Points.AddY( _mainForm.bodyCharts[i, 2] );
            }
        }

        #endregion
    }
}