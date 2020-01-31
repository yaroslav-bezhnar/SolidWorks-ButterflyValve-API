using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class ShaftChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public ShaftChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void ShaftChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.shaftCharts.Length / 3; i++ )
            {
                chartShaftMass.Series[0].Points.AddY( _mainForm.shaftCharts[i, 0] );
                chartShaftSquare.Series[0].Points.AddY( _mainForm.shaftCharts[i, 1] );
                chartShaftVolume.Series[0].Points.AddY( _mainForm.shaftCharts[i, 2] );
            }
        }

        #endregion
    }
}