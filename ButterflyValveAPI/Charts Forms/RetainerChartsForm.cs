using System;
using System.Windows.Forms;

namespace ButterflyValveAPI
{
    public partial class RetainerChartsForm : Form
    {
        #region Fields

        private ButterflyValveForm _mainForm;

        #endregion

        #region Constructors

        public RetainerChartsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods

        private void RetainerChartsForm_Load( object sender, EventArgs e )
        {
            _mainForm = Owner as ButterflyValveForm;

            for ( var i = 0; i < _mainForm?.retainerCharts.Length / 3; i++ )
            {
                chartRetainerMass.Series[0].Points.AddY( _mainForm.retainerCharts[i, 0] );
                chartRetainerSquare.Series[0].Points.AddY( _mainForm.retainerCharts[i, 1] );
                chartRetainerVolume.Series[0].Points.AddY( _mainForm.retainerCharts[i, 2] );
            }
        }

        #endregion
    }
}