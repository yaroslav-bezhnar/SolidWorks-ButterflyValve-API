using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class NutChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public NutChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void NutChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.nutCharts.Length / 3; i++ )
            {
                chartNutMass.Series[0].Points.AddY( _mainForm.nutCharts[i, 0] );
                chartNutSquare.Series[0].Points.AddY( _mainForm.nutCharts[i, 1] );
                chartNutVolume.Series[0].Points.AddY( _mainForm.nutCharts[i, 2] );
            }
        }

        #endregion
    }
}