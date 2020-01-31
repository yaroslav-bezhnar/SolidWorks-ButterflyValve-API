using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    public partial class ButterflyValveForm : Form
    {
        #region Fields

        private BVNut _nut;
        private BVPlate _plate;
        private BVScrew _screw;
        private BVRetainer _retainer;
        private BVArm _arm;
        private BVShaft _shaft;
        private BVBody _body;
        private ButterflyValveAssembly _butterflyValve;
        private string _material;
        private string _newPlace;
        private ArmChartsForm _chartsArm;
        private PlateChartsForm _chartsPlate;
        private NutChartsForm _chartsNut;
        private ShaftChartsForm _chartsShaft;
        private ScrewChartsForm _chartsScrew;
        private RetainerChartsForm _chartsRetainer;
        private BodyChartsForm _chartsBody;
        private AssemblyChartsForm _chartsAssembly;

        public double[,] armCharts, plateCharts, nutCharts, shaftCharts, screwCharts, retainerCharts, bodyCharts, assemblyCharts;

        #endregion

        #region Initializations / Finalizations Methods

        public ButterflyValveForm()
        {
            InitializeComponent();
        }

        private void ButterflyValveForm_Load( object sender, EventArgs e )
        {
            try
            {
                _arm = new BVArm();
                _plate = new BVPlate();
                _nut = new BVNut();
                _shaft = new BVShaft();
                _screw = new BVScrew();
                _retainer = new BVRetainer();
                _body = new BVBody();
                _butterflyValve = new ButterflyValveAssembly();

                var headerCenter = new DataGridViewCellStyle();
                headerCenter.Alignment = DataGridViewContentAlignment.MiddleCenter;

                bodyDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.BodyDimensions );
                retainerDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.RetainerDimensions );
                screwDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.ScrewDimensions );
                shaftDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.ShaftDimensions );
                nutDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.NutDimensions );
                plateDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.PlateDimensions );
                armDimensionsTableAdapter.Fill( butterfly_Valve_DimensionsDataSet.ArmDimensions );

                armDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                plateDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                nutDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                shaftDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                screwDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                retainerDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                bodyDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
            }
            catch ( Exception )
            {
                MessageBox.Show( @"AAAAAA", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        #endregion

        #region Create Parts

        private void buttonArm_Click( object sender, EventArgs e ) // Arm
        {
            _arm.CreatePart();
        }

        private void buttonPlate_Click( object sender, EventArgs e ) // Plate
        {
            _plate.CreatePart();
        }

        private void buttonNut_Click( object sender, EventArgs e ) // Nut
        {
            _nut.CreatePart();
        }

        private void buttonShaft_Click( object sender, EventArgs e ) // Shaft
        {
            _shaft.CreatePart();
        }

        private void buttonScrew_Click( object sender, EventArgs e ) // Screw
        {
            _screw.CreatePart();
        }

        private void buttonRetainer_Click( object sender, EventArgs e ) // Retainer
        {
            _retainer.CreatePart();
        }

        private void buttonBody_Click( object sender, EventArgs e ) // Body
        {
            _body.CreatePart();
        }

        private void buttonAssembly_Click( object sender, EventArgs e ) // Assembly
        {
            _butterflyValve.CreateButterflyValveAssembly();
        }

        private void buttonOpenExistAssembly_Click( object sender, EventArgs e )
        {
            _butterflyValve.OpenButterflyValveAssembly();
        }

        #endregion

        #region Set Materials

        private void comboBoxArmMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Arm material
        {
            try
            {
                _material = comboBoxArmMaterial.SelectedItem.ToString();
                _arm.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxPlateMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Plate material
        {
            try
            {
                _material = comboBoxPlateMaterial.SelectedItem.ToString();
                _plate.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxNutMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Nut material
        {
            try
            {
                _material = comboBoxNutMaterial.SelectedItem.ToString();
                _nut.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxShaftMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Shaft material
        {
            try
            {
                _material = comboBoxShaftMaterial.SelectedItem.ToString();
                _shaft.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxScrewMaterial_SelectedIndexChanged( object sender, EventArgs e ) //Screw material
        {
            try
            {
                _material = comboBoxScrewMaterial.SelectedItem.ToString();
                _screw.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxRetainerMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Retainer material
        {
            try
            {
                _material = comboBoxRetainerMaterial.SelectedItem.ToString();
                _retainer.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void comboBoxBodyMaterial_SelectedIndexChanged( object sender, EventArgs e ) // Body material
        {
            try
            {
                _material = comboBoxBodyMaterial.SelectedItem.ToString();
                _body.SetMaterial( _material );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        #endregion

        #region Get Mass Properties

        private void buttonArmMassProps_Click( object sender, EventArgs e ) // Arm Props
        {
            try
            {
                dgvArmProperties.Rows.Add( _arm.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearArmProps_Click( object sender, EventArgs e )
        {
            dgvArmProperties.Rows.Clear();
        }

        private void buttonPlateMassProps_Click( object sender, EventArgs e ) // Plate Props
        {
            try
            {
                dgvPlateProperties.Rows.Add( _plate.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearPlateProps_Click( object sender, EventArgs e )
        {
            dgvPlateProperties.Rows.Clear();
        }

        private void buttonNutMassProps_Click( object sender, EventArgs e ) // Nut Props
        {
            try
            {
                dgvNutProperties.Rows.Add( _nut.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearNutProps_Click( object sender, EventArgs e )
        {
            dgvNutProperties.Rows.Clear();
        }

        private void buttonShaftMassProps_Click( object sender, EventArgs e ) // Shaft Props
        {
            try
            {
                dgvShaftProperties.Rows.Add( _shaft.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearShaftProps_Click( object sender, EventArgs e )
        {
            dgvShaftProperties.Rows.Clear();
        }

        private void buttonScrewMassProps_Click( object sender, EventArgs e ) // Screw Props
        {
            try
            {
                dgvScrewProperties.Rows.Add( _screw.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearScrewProps_Click( object sender, EventArgs e )
        {
            dgvScrewProperties.Rows.Clear();
        }

        private void buttonRetainerMassProps_Click( object sender, EventArgs e ) // Retainer Props
        {
            try
            {
                dgvRetainerProperties.Rows.Add( _retainer.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearRetainerProps_Click( object sender, EventArgs e )
        {
            dgvRetainerProperties.Rows.Clear();
        }

        private void buttonBodyMassProps_Click( object sender, EventArgs e ) // Body Props
        {
            try
            {
                dgvBodyProperties.Rows.Add( _body.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь або встановіть матеріал", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearBodyProps_Click( object sender, EventArgs e )
        {
            dgvBodyProperties.Rows.Clear();
        }

        private void buttonAssemblyMassProps_Click( object sender, EventArgs e ) // Assembly Props
        {
            try
            {
                dgvAssemblyProperties.Rows.Add( _butterflyValve.GetMassProperties() );
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть збірку або відкрийте існуючу", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void buttonClearAssemblyProps_Click( object sender, EventArgs e )
        {
            dgvAssemblyProperties.Rows.Clear();
        }

        #endregion
     
        #region Change Dimensions

        private void armDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _arm.NewArmDim = new double[armDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < armDimensionsDataGridView.ColumnCount; i++ )
                {
                    _arm.NewArmDim[i] = Convert.ToDouble( armDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _arm.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void plateDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _plate.NewPlateDim = new double[plateDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < plateDimensionsDataGridView.ColumnCount; i++ )
                {
                    _plate.NewPlateDim[i] = Convert.ToDouble( plateDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _plate.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void nutDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _nut.NewNutDim = new double[nutDimensionsDataGridView.ColumnCount];
                for ( int i = 0; i < nutDimensionsDataGridView.ColumnCount; i++ )
                {
                    _nut.NewNutDim[i] = Convert.ToDouble( nutDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _nut.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void shaftDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _shaft.NewShaftDim = new double[shaftDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < shaftDimensionsDataGridView.ColumnCount; i++ )
                {
                    _shaft.NewShaftDim[i] = Convert.ToDouble( shaftDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _shaft.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void screwDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _screw.NewScrewDim = new double[screwDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < screwDimensionsDataGridView.ColumnCount; i++ )
                {
                    _screw.NewScrewDim[i] = Convert.ToDouble( screwDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _screw.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void retainerDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _retainer.NewRetainerDim = new double[retainerDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < retainerDimensionsDataGridView.ColumnCount; i++ )
                {
                    _retainer.NewRetainerDim[i] = Convert.ToDouble( retainerDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _retainer.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void bodyDimensionsDataGridView_CellClick( object sender, DataGridViewCellEventArgs e )
        {
            try
            {
                _body.NewBodyDim = new double[bodyDimensionsDataGridView.ColumnCount];
                for ( var i = 0; i < bodyDimensionsDataGridView.ColumnCount; i++ )
                {
                    _body.NewBodyDim[i] = Convert.ToDouble( bodyDimensionsDataGridView[i, e.RowIndex].Value );
                }

                _body.ChangeDimensions();
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
            catch ( ArgumentOutOfRangeException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        #endregion

        #region Open And Save

        private void openToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var processes = Process.GetProcessesByName( "SLDWORKS" );
            foreach ( var process in processes )
            {
                process.CloseMainWindow();
                process.Kill();
            }

            if ( tabControl1.SelectedTab == tabPageArm )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _arm.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPagePlate )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _plate.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageNut )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _nut.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageShaft )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _shaft.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageScrew )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _screw.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageRetainer )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _retainer.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageBody )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _body.OpenPart( openFileDialog1.FileName );
                }
            }
            else if ( tabControl1.SelectedTab == tabPageAssembly )
            {
                if ( openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    _butterflyValve.OpenPart( openFileDialog1.FileName );
                }
            }
            else
            {
                MessageBox.Show( "asdf" );
            }
        }

        private void saveToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                if ( tabControl1.SelectedTab == tabPageArm )
                {
                    _arm.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPagePlate )
                {
                    _plate.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageNut )
                {
                    _nut.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageShaft )
                {
                    _shaft.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageScrew )
                {
                    _screw.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageRetainer )
                {
                    _retainer.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageBody )
                {
                    _body.SavePart();
                }
                else if ( tabControl1.SelectedTab == tabPageAssembly )
                {
                    _butterflyValve.SavePart();
                }
                else
                {
                    MessageBox.Show( "qwe" );
                }
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void saveAsToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                if ( tabControl1.SelectedTab == tabPageArm )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _arm.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPagePlate )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _plate.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageNut )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _nut.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageShaft )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _shaft.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageScrew )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _screw.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageRetainer )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _retainer.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageBody )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDPRT";
                    _body.SavePart( _newPlace );
                }
                else if ( tabControl1.SelectedTab == tabPageAssembly )
                {
                    saveFileDialog1.ShowDialog();
                    _newPlace = saveFileDialog1.FileName + @".SLDASM";
                    _butterflyValve.SavePart( _newPlace );
                }
                else
                {
                    MessageBox.Show( "vbn" );
                }
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show( @"Будь ласка, створіть деталь", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
            catch ( COMException )
            {
                MessageBox.Show( $@"Вибачте :( {Environment.NewLine}Дія неможлива", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        #endregion

        #region Charts

        private void buttonArmCharts_Click( object sender, EventArgs e )
        {
            _chartsArm = new ArmChartsForm();
            _chartsArm.Owner = this;

            armCharts = new double[dgvArmProperties.RowCount, dgvArmProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvArmProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvArmProperties.ColumnCount - 1; j++ )
                {
                    armCharts[i, j] = Convert.ToDouble( dgvArmProperties[j, i].Value );
                }
            }

            if ( dgvArmProperties.Rows.Count != 0 )
            {
                _chartsArm.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonPlateCharts_Click( object sender, EventArgs e )
        {
            _chartsPlate = new PlateChartsForm();
            _chartsPlate.Owner = this;

            plateCharts = new double[dgvPlateProperties.RowCount, dgvPlateProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvPlateProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvPlateProperties.ColumnCount - 1; j++ )
                {
                    plateCharts[i, j] = Convert.ToDouble( dgvPlateProperties[j, i].Value );
                }
            }

            if ( dgvPlateProperties.Rows.Count != 0 )
            {
                _chartsPlate.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonNutCharts_Click( object sender, EventArgs e )
        {
            _chartsNut = new NutChartsForm();
            _chartsNut.Owner = this;

            nutCharts = new double[dgvNutProperties.RowCount, dgvNutProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvNutProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvNutProperties.ColumnCount - 1; j++ )
                {
                    nutCharts[i, j] = Convert.ToDouble( dgvNutProperties[j, i].Value );
                }
            }

            if ( dgvNutProperties.Rows.Count != 0 )
            {
                _chartsNut.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonShaftCharts_Click( object sender, EventArgs e )
        {
            _chartsShaft = new ShaftChartsForm();
            _chartsShaft.Owner = this;

            shaftCharts = new double[dgvShaftProperties.RowCount, dgvShaftProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvShaftProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvShaftProperties.ColumnCount - 1; j++ )
                {
                    shaftCharts[i, j] = Convert.ToDouble( dgvShaftProperties[j, i].Value );
                }
            }

            if ( dgvShaftProperties.Rows.Count != 0 )
            {
                _chartsShaft.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonScrewCharts_Click( object sender, EventArgs e )
        {
            _chartsScrew = new ScrewChartsForm();
            _chartsScrew.Owner = this;

            screwCharts = new double[dgvScrewProperties.RowCount, dgvScrewProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvScrewProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvScrewProperties.ColumnCount - 1; j++ )
                {
                    screwCharts[i, j] = Convert.ToDouble( dgvScrewProperties[j, i].Value );
                }
            }

            if ( dgvScrewProperties.Rows.Count != 0 )
            {
                _chartsScrew.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonRetainerCharts_Click( object sender, EventArgs e )
        {
            _chartsRetainer = new RetainerChartsForm();
            _chartsRetainer.Owner = this;

            retainerCharts = new double[dgvRetainerProperties.RowCount, dgvRetainerProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvRetainerProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvRetainerProperties.ColumnCount - 1; j++ )
                {
                    retainerCharts[i, j] = Convert.ToDouble( dgvRetainerProperties[j, i].Value );
                }
            }

            if ( dgvRetainerProperties.Rows.Count != 0 )
            {
                _chartsRetainer.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonBodyCharts_Click( object sender, EventArgs e )
        {
            _chartsBody = new BodyChartsForm();
            _chartsBody.Owner = this;

            bodyCharts = new double[dgvBodyProperties.RowCount, dgvBodyProperties.ColumnCount - 1];

            for ( var i = 0; i < dgvBodyProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvBodyProperties.ColumnCount - 1; j++ )
                {
                    bodyCharts[i, j] = Convert.ToDouble( dgvBodyProperties[j, i].Value );
                }
            }

            if ( dgvBodyProperties.Rows.Count != 0 )
            {
                _chartsBody.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void buttonAssemblyCharts_Click( object sender, EventArgs e )
        {
            _chartsAssembly = new AssemblyChartsForm();
            _chartsAssembly.Owner = this;

            assemblyCharts = new double[dgvAssemblyProperties.RowCount, dgvAssemblyProperties.ColumnCount];

            for ( var i = 0; i < dgvAssemblyProperties.RowCount; i++ )
            {
                for ( var j = 0; j < dgvAssemblyProperties.ColumnCount; j++ )
                {
                    assemblyCharts[i, j] = Convert.ToDouble( dgvAssemblyProperties[j, i].Value );
                }
            }

            if ( dgvAssemblyProperties.Rows.Count != 0 )
            {
                _chartsAssembly.ShowDialog();
            }
            else
            {
                MessageBox.Show( @"Немає даних для графіків", @"Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        #endregion

        #region Private Methods

        private void buttonSimulation_Click( object sender, EventArgs e )
        {
            _butterflyValve.AssemblySimulation();
        }

        private void buttonViewResults_Click( object sender, EventArgs e )
        {
            _butterflyValve.OpenSimulation();
        }

        private void buttonMotion_Click( object sender, EventArgs e )
        {
            _butterflyValve.ShowMotion();
        }

        #endregion
    }
}
