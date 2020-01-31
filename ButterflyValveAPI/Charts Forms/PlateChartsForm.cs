using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class PlateChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public PlateChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void PlateChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.plateCharts.Length / 3; i++ )
            {
                chartPlateMass.Series[0].Points.AddY( _mainForm.plateCharts[i, 0] );
                chartPlateSquare.Series[0].Points.AddY( _mainForm.plateCharts[i, 1] );
                chartPlateVolume.Series[0].Points.AddY( _mainForm.plateCharts[i, 2] );
            }
        }

        #endregion
    }
}