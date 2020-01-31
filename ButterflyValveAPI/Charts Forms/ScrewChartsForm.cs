using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class ScrewChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public ScrewChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void ScrewChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.screwCharts.Length / 3; i++ )
            {
                chartScrewMass.Series[0].Points.AddY( _mainForm.screwCharts[i, 0] );
                chartScrewSquare.Series[0].Points.AddY( _mainForm.screwCharts[i, 1] );
                chartScrewVolume.Series[0].Points.AddY( _mainForm.screwCharts[i, 2] );
            }
        }

        #endregion
    }
}