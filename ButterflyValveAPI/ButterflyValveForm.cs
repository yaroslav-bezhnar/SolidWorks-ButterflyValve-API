using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    public partial class ButterflyValveForm : Form
    {
        BVNut nut;
        BVPlate plate;
        BVScrew screw;
        BVRetainer retainer;
        BVArm arm;
        BVShaft shaft;
        BVBody body;
        ButterflyValveAssembly butterflyValve;
        string material, newPlace;
        public double[,] armCharts, plateCharts, nutCharts, shaftCharts, screwCharts, retainerCharts, bodyCharts, assemblyCharts;
        ArmChartsForm chartsArm;
        PlateChartsForm chartsPlate;
        NutChartsForm chartsNut;
        ShaftChartsForm chartsShaft;
        ScrewChartsForm chartsScrew;
        RetainerChartsForm chartsRetainer;
        BodyChartsForm chartsBody;
        AssemblyChartsForm chartsAssembly;
        public ButterflyValveForm()
        {
            InitializeComponent();
        }
        private void ButterflyValveForm_Load(object sender, EventArgs e)
        {
            try
            {
                arm = new BVArm(); plate = new BVPlate(); nut = new BVNut(); shaft = new BVShaft();
                screw = new BVScrew(); retainer = new BVRetainer(); body = new BVBody();
                butterflyValve = new ButterflyValveAssembly();
                DataGridViewCellStyle headerCenter = new DataGridViewCellStyle();
                headerCenter.Alignment = DataGridViewContentAlignment.MiddleCenter;

                this.bodyDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.BodyDimensions);
                this.retainerDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.RetainerDimensions);
                this.screwDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.ScrewDimensions);
                this.shaftDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.ShaftDimensions);
                this.nutDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.NutDimensions);
                this.plateDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.PlateDimensions);
                this.armDimensionsTableAdapter.Fill(this.butterfly_Valve_DimensionsDataSet.ArmDimensions);

                armDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                plateDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                nutDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                shaftDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                screwDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                retainerDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
                bodyDimensionsDataGridView.ColumnHeadersDefaultCellStyle = headerCenter;
            }
            catch (Exception) 
            {
                MessageBox.Show("AAAAAA", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        #region Create Parts
        private void buttonArm_Click(object sender, EventArgs e) // Arm
        {
            arm.CreatePart();
         //   axEModelViewControl1.OpenDoc(arm.place, false, false, true, "");
        }
        private void buttonPlate_Click(object sender, EventArgs e) // Plate
        {
            plate.CreatePart();
        //    axEModelViewControl1.OpenDoc(plate.place, false, false, true, "");
        }
        private void buttonNut_Click(object sender, EventArgs e) // Nut
        {
            nut.CreatePart();
        //    axEModelViewControl1.OpenDoc(nut.place, false, false, true, "");
        }
        private void buttonShaft_Click(object sender, EventArgs e) // Shaft
        {
            shaft.CreatePart();
        //    axEModelViewControl1.OpenDoc(shaft.place, false, false, true, "");
        }
        private void buttonScrew_Click(object sender, EventArgs e) // Screw
        {
            screw.CreatePart();
        //    axEModelViewControl1.OpenDoc(screw.place, false, false, true, "");
        }
        private void buttonRetainer_Click(object sender, EventArgs e) // Retainer
        {
            retainer.CreatePart();
         //   axEModelViewControl1.OpenDoc(retainer.place, false, false, true, "");
        }
        private void buttonBody_Click(object sender, EventArgs e) // Body
        {
            body.CreatePart();
         //   axEModelViewControl1.OpenDoc(body.place, false, false, true, "");
        }
        private void buttonAssembly_Click(object sender, EventArgs e) // Assembly
        {
            butterflyValve.CreateButterflyValveAssembly();
        //    axEModelViewControl1.OpenDoc(butterflyValve.place, false, false, true, "");
        }
        private void buttonOpenExistAssembly_Click(object sender, EventArgs e)
        {
            butterflyValve.OpenButterflyValveAssembly();
         //   axEModelViewControl1.OpenDoc(butterflyValve.place, false, false, true, "");
        }

        #endregion
        
        #region Set Materials

        private void comboBoxArmMaterial_SelectedIndexChanged(object sender, EventArgs e) // Arm material
        {
            try
            {
                material = comboBoxArmMaterial.SelectedItem.ToString();
                arm.SetMaterial(material);
             //   axEModelViewControl1.OpenDoc(arm.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxPlateMaterial_SelectedIndexChanged(object sender, EventArgs e) // Plate material
        {
            try
            {
                material = comboBoxPlateMaterial.SelectedItem.ToString();
                plate.SetMaterial(material);
              //  axEModelViewControl1.OpenDoc(plate.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxNutMaterial_SelectedIndexChanged(object sender, EventArgs e) // Nut material
        {
            try
            {
                material = comboBoxNutMaterial.SelectedItem.ToString();
                nut.SetMaterial(material);
            //    axEModelViewControl1.OpenDoc(nut.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxShaftMaterial_SelectedIndexChanged(object sender, EventArgs e) // Shaft material
        {
            try
            {
                material = comboBoxShaftMaterial.SelectedItem.ToString();
                shaft.SetMaterial(material);
             //   axEModelViewControl1.OpenDoc(shaft.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxScrewMaterial_SelectedIndexChanged(object sender, EventArgs e) //Screw material
        {
            try
            {
                material = comboBoxScrewMaterial.SelectedItem.ToString();
                screw.SetMaterial(material);
             //   axEModelViewControl1.OpenDoc(screw.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxRetainerMaterial_SelectedIndexChanged(object sender, EventArgs e) // Retainer material
        {
            try
            {
                material = comboBoxRetainerMaterial.SelectedItem.ToString();
                retainer.SetMaterial(material);
             //   axEModelViewControl1.OpenDoc(retainer.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void comboBoxBodyMaterial_SelectedIndexChanged(object sender, EventArgs e) // Body material
        {
            try
            {
                material = comboBoxBodyMaterial.SelectedItem.ToString();
                body.SetMaterial(material);
           //     axEModelViewControl1.OpenDoc(body.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        #endregion
        
        #region Get Mass Properties
        private void buttonArmMassProps_Click(object sender, EventArgs e) // Arm Props
        {
            try
            {
                dgvArmProperties.Rows.Add(arm.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearArmProps_Click(object sender, EventArgs e)
        {
            dgvArmProperties.Rows.Clear();
        }
        private void buttonPlateMassProps_Click(object sender, EventArgs e) // Plate Props
        {
            try
            {
                dgvPlateProperties.Rows.Add(plate.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearPlateProps_Click(object sender, EventArgs e)
        {
            dgvPlateProperties.Rows.Clear();
        }
        private void buttonNutMassProps_Click(object sender, EventArgs e) // Nut Props
        {
            try
            {
                dgvNutProperties.Rows.Add(nut.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearNutProps_Click(object sender, EventArgs e)
        {
            dgvNutProperties.Rows.Clear();
        }
        private void buttonShaftMassProps_Click(object sender, EventArgs e) // Shaft Props
        {
            try
            {
                dgvShaftProperties.Rows.Add(shaft.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearShaftProps_Click(object sender, EventArgs e)
        {
            dgvShaftProperties.Rows.Clear();
        }
        private void buttonScrewMassProps_Click(object sender, EventArgs e) // Screw Props
        {
            try
            {
                dgvScrewProperties.Rows.Add(screw.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearScrewProps_Click(object sender, EventArgs e)
        {
            dgvScrewProperties.Rows.Clear();
        }
        private void buttonRetainerMassProps_Click(object sender, EventArgs e) // Retainer Props
        {
            try
            {
                dgvRetainerProperties.Rows.Add(retainer.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearRetainerProps_Click(object sender, EventArgs e)
        {
            dgvRetainerProperties.Rows.Clear();
        }
        private void buttonBodyMassProps_Click(object sender, EventArgs e) // Body Props
        {
            try
            {
                dgvBodyProperties.Rows.Add(body.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь або встановіть матеріал", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearBodyProps_Click(object sender, EventArgs e)
        {
            dgvBodyProperties.Rows.Clear();
        }
        private void buttonAssemblyMassProps_Click(object sender, EventArgs e) // Assembly Props
        {
            try
            {
                dgvAssemblyProperties.Rows.Add(butterflyValve.GetMassProperties());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть збірку або відкрийте існуючу", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void buttonClearAssemblyProps_Click(object sender, EventArgs e)
        {
            dgvAssemblyProperties.Rows.Clear();
        }
        #endregion
     
        #region Change Dimensions
        private void armDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                arm.newArmDim = new double[armDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < armDimensionsDataGridView.ColumnCount; i++)
                {
                    arm.newArmDim[i] = Convert.ToDouble(armDimensionsDataGridView[i, e.RowIndex].Value);
                }
                arm.ChangeDimensions();
         //       axEModelViewControl1.OpenDoc(arm.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void plateDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                plate.newPlateDim = new double[plateDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < plateDimensionsDataGridView.ColumnCount; i++)
                {
                    plate.newPlateDim[i] = Convert.ToDouble(plateDimensionsDataGridView[i, e.RowIndex].Value);
                }
                plate.ChangeDimensions();
        //        axEModelViewControl1.OpenDoc(plate.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void nutDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nut.newNutDim = new double[nutDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < nutDimensionsDataGridView.ColumnCount; i++)
                {
                    nut.newNutDim[i] = Convert.ToDouble(nutDimensionsDataGridView[i, e.RowIndex].Value);
                }
                nut.ChangeDimensions();
          //      axEModelViewControl1.OpenDoc(nut.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void shaftDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                shaft.newShaftDim = new double[shaftDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < shaftDimensionsDataGridView.ColumnCount; i++)
                {
                    shaft.newShaftDim[i] = Convert.ToDouble(shaftDimensionsDataGridView[i, e.RowIndex].Value);
                }
                shaft.ChangeDimensions();
            //    axEModelViewControl1.OpenDoc(shaft.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void screwDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                screw.newScrewDim = new double[screwDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < screwDimensionsDataGridView.ColumnCount; i++)
                {
                    screw.newScrewDim[i] = Convert.ToDouble(screwDimensionsDataGridView[i, e.RowIndex].Value);
                }
                screw.ChangeDimensions();
          //      axEModelViewControl1.OpenDoc(screw.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void retainerDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                retainer.newRetainerDim = new double[retainerDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < retainerDimensionsDataGridView.ColumnCount; i++)
                {
                    retainer.newRetainerDim[i] = Convert.ToDouble(retainerDimensionsDataGridView[i, e.RowIndex].Value);
                }
                retainer.ChangeDimensions();
          //      axEModelViewControl1.OpenDoc(retainer.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void bodyDimensionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                body.newBodyDim = new double[bodyDimensionsDataGridView.ColumnCount];
                for (int i = 0; i < bodyDimensionsDataGridView.ColumnCount; i++)
                {
                    body.newBodyDim[i] = Convert.ToDouble(bodyDimensionsDataGridView[i, e.RowIndex].Value);
                }
                body.ChangeDimensions();
           //     axEModelViewControl1.OpenDoc(body.place, false, false, true, "");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        #endregion

        #region Open And Save
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }
            if (tabControl1.SelectedTab == tabPageArm)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    arm.OpenPart(openFileDialog1.FileName.ToString());
          //          axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPagePlate)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    plate.OpenPart(openFileDialog1.FileName.ToString());
           //         axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageNut)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    nut.OpenPart(openFileDialog1.FileName.ToString());
            //        axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageShaft)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    shaft.OpenPart(openFileDialog1.FileName.ToString());
            //        axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageScrew)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    screw.OpenPart(openFileDialog1.FileName.ToString());
           //         axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageRetainer)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    retainer.OpenPart(openFileDialog1.FileName.ToString());
           //         axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageBody)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    body.OpenPart(openFileDialog1.FileName.ToString());
              //      axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else if (tabControl1.SelectedTab == tabPageAssembly)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    butterflyValve.OpenPart(openFileDialog1.FileName.ToString());
               //     axEModelViewControl1.OpenDoc(openFileDialog1.FileName.ToString(), false, false, true, "");
                }
            }
            else { MessageBox.Show("asdf"); }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabPageArm)
                {
                    arm.SavePart();
                //    axEModelViewControl1.OpenDoc(arm.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPagePlate)
                {
                    plate.SavePart();
                 //   axEModelViewControl1.OpenDoc(plate.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageNut)
                {
                    nut.SavePart();
                //    axEModelViewControl1.OpenDoc(nut.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageShaft)
                {
                    shaft.SavePart();
               //     axEModelViewControl1.OpenDoc(shaft.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageScrew)
                {
                    screw.SavePart();
                 //   axEModelViewControl1.OpenDoc(screw.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageRetainer)
                {
                    retainer.SavePart();
             //       axEModelViewControl1.OpenDoc(retainer.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageBody)
                {
                    body.SavePart();
              //      axEModelViewControl1.OpenDoc(body.place, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageAssembly)
                {
                    butterflyValve.SavePart();
                //    axEModelViewControl1.OpenDoc(butterflyValve.place, false, false, true, "");
                }
                else
                {
                    MessageBox.Show("qwe");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabPageArm)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    arm.SavePart(newPlace);
                 //   axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPagePlate)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    plate.SavePart(newPlace);
              //      axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageNut)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    nut.SavePart(newPlace);
                //    axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageShaft)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    shaft.SavePart(newPlace);
             //       axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageScrew)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    screw.SavePart(newPlace);
               //     axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageRetainer)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    retainer.SavePart(newPlace);
                 //   axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageBody)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDPRT";
                    body.SavePart(newPlace);
                //    axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else if (tabControl1.SelectedTab == tabPageAssembly)
                {
                    saveFileDialog1.ShowDialog();
                    newPlace = saveFileDialog1.FileName.ToString() + ".SLDASM";
                    butterflyValve.SavePart(newPlace);
                 //   axEModelViewControl1.OpenDoc(newPlace, false, false, true, "");
                }
                else
                {
                    MessageBox.Show("vbn");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Будь ласка, створіть деталь", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                MessageBox.Show("Вибачте :( \nДія неможлива", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        #endregion

        #region Charts
        private void buttonArmCharts_Click(object sender, EventArgs e)
        {
            chartsArm = new ArmChartsForm();
            chartsArm.Owner = this;
            armCharts = new double[dgvArmProperties.RowCount, dgvArmProperties.ColumnCount - 1];
            for (int i = 0; i < dgvArmProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvArmProperties.ColumnCount - 1; j++)
                {
                    armCharts[i, j] = Convert.ToDouble(dgvArmProperties[j, i].Value);
                }
            }
            if (dgvArmProperties.Rows.Count != 0)
            {
                chartsArm.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonPlateCharts_Click(object sender, EventArgs e)
        {
            chartsPlate = new PlateChartsForm();
            chartsPlate.Owner = this;
            plateCharts = new double[dgvPlateProperties.RowCount, dgvPlateProperties.ColumnCount - 1];
            for (int i = 0; i < dgvPlateProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvPlateProperties.ColumnCount - 1; j++)
                {
                    plateCharts[i, j] = Convert.ToDouble(dgvPlateProperties[j, i].Value);
                }
            }
            if (dgvPlateProperties.Rows.Count != 0)
            {
                chartsPlate.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonNutCharts_Click(object sender, EventArgs e)
        {
            chartsNut = new NutChartsForm();
            chartsNut.Owner = this;
            nutCharts = new double[dgvNutProperties.RowCount, dgvNutProperties.ColumnCount - 1];
            for (int i = 0; i < dgvNutProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvNutProperties.ColumnCount - 1; j++)
                {
                    nutCharts[i, j] = Convert.ToDouble(dgvNutProperties[j, i].Value);
                }
            }
            if (dgvNutProperties.Rows.Count != 0)
            {
                chartsNut.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonShaftCharts_Click(object sender, EventArgs e)
        {
            chartsShaft = new ShaftChartsForm();
            chartsShaft.Owner = this;
            shaftCharts = new double[dgvShaftProperties.RowCount, dgvShaftProperties.ColumnCount - 1];
            for (int i = 0; i < dgvShaftProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvShaftProperties.ColumnCount - 1; j++)
                {
                    shaftCharts[i, j] = Convert.ToDouble(dgvShaftProperties[j, i].Value);
                }
            }
            if (dgvShaftProperties.Rows.Count != 0)
            {
                chartsShaft.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonScrewCharts_Click(object sender, EventArgs e)
        {
            chartsScrew = new ScrewChartsForm();
            chartsScrew.Owner = this;
            screwCharts = new double[dgvScrewProperties.RowCount, dgvScrewProperties.ColumnCount - 1];
            for (int i = 0; i < dgvScrewProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvScrewProperties.ColumnCount - 1; j++)
                {
                    screwCharts[i, j] = Convert.ToDouble(dgvScrewProperties[j, i].Value);
                }
            }
            if (dgvScrewProperties.Rows.Count != 0)
            {
                chartsScrew.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonRetainerCharts_Click(object sender, EventArgs e)
        {
            chartsRetainer = new RetainerChartsForm();
            chartsRetainer.Owner = this;
            retainerCharts = new double[dgvRetainerProperties.RowCount, dgvRetainerProperties.ColumnCount - 1];
            for (int i = 0; i < dgvRetainerProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvRetainerProperties.ColumnCount - 1; j++)
                {
                    retainerCharts[i, j] = Convert.ToDouble(dgvRetainerProperties[j, i].Value);
                }
            }
            if (dgvRetainerProperties.Rows.Count != 0)
            {
                chartsRetainer.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonBodyCharts_Click(object sender, EventArgs e)
        {
            chartsBody = new BodyChartsForm();
            chartsBody.Owner = this;
            bodyCharts = new double[dgvBodyProperties.RowCount, dgvBodyProperties.ColumnCount - 1];
            for (int i = 0; i < dgvBodyProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvBodyProperties.ColumnCount - 1; j++)
                {
                    bodyCharts[i, j] = Convert.ToDouble(dgvBodyProperties[j, i].Value);
                }
            }
            if (dgvBodyProperties.Rows.Count != 0)
            {
                chartsBody.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonAssemblyCharts_Click(object sender, EventArgs e)
        {
            chartsAssembly = new AssemblyChartsForm();
            chartsAssembly.Owner = this;
            assemblyCharts = new double[dgvAssemblyProperties.RowCount, dgvAssemblyProperties.ColumnCount];
            for (int i = 0; i < dgvAssemblyProperties.RowCount; i++)
            {
                for (int j = 0; j < dgvAssemblyProperties.ColumnCount; j++)
                {
                    assemblyCharts[i, j] = Convert.ToDouble(dgvAssemblyProperties[j, i].Value);
                }
            }
            if (dgvAssemblyProperties.Rows.Count != 0)
            {
                chartsAssembly.ShowDialog();
            }
            else { MessageBox.Show("Немає даних для графіків", "Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        #endregion

        private void buttonSimulation_Click(object sender, EventArgs e)
        {
            butterflyValve.AssemblySimulation();
        }

        private void buttonViewResults_Click(object sender, EventArgs e)
        {
            butterflyValve.OpenSimulation();
        }

        private void buttonMotion_Click(object sender, EventArgs e)
        {
            butterflyValve.ShowMotion();
        }
    }
}
