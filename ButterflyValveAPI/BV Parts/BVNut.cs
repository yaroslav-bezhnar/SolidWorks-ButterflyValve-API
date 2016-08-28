using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    class BVNut: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempNut.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newNutDim;
 
        public void CreatePart()
        {
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }

            object processSW = System.Activator.CreateInstance(System.Type.GetTypeFromProgID("SldWorks.Application"));
            swApp = (SldWorks)processSW;
            swApp.Visible = true;

            swModel = swApp.NewDocument("C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2015\\templates\\Part.prtdot", 0, 0, 0);
            swApp.ActivateDoc2("Part1", false, longstatus);

            swApp.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swInputDimValOnCreate)), false);

            swApp.ActivateDoc2("Part7", false, longstatus);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.011275, 0.005443, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 1.36078625033716E-02, 0, 3.88796071524894E-04, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(5.44314500134863E-02, 0, 7.77592143049802E-04);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.037;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SetPickMode();
            swModel.SketchManager.CreatePolygon(0, 0, 0, 5.17040853292076E-02, 0, 0, 6, true);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", -4.42357174483221E-02, 0, -1.14897967398239E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-9.70887824515121E-02, 0, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.069;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 6, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);

            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.039837, 0.0125, 0, -0.035194, 0.0125, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.039837, 0.0125, 0, -0.039837, 0.009392, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.Create3PointArc(-0.039837, 0.009392, 0, -0.035194, 0.0125, 0, -0.037611, 0.011406, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Right Plane", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.InsertAxis2(true);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, false, 0, null, 0);
            swModel.BlankRefGeom();
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swModel.EditSketch();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -3.72688966976747E-02, 1.25081999398274E-02, 4.44837737757098E-03, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -3.74111865665304E-02, 0.012275361972609, 4.20192409535503E-03, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);

            boolstatus = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swModel.EditSketch();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -3.98057597530716E-02, 1.08657361303514E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-4.35906778009545E-02, 1.11083590821388E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch2");
            myDimension.SystemValue = 0.008;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -3.78162515484152E-02, 1.24185230217906E-02, 3.50033096617608E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-3.75736285966278E-02, 0.016057867298601, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch2");
            myDimension.SystemValue = 0.008;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -3.86896941748497E-02, 1.32919656482251E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-4.49978909213212E-02, 1.64945886118183E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch2");
            myDimension.SystemValue = 0.008;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);

            boolstatus = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, true, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, true, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, true, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);

            swApp.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swInputDimValOnCreate)), true);

            swModel.SaveAs4(place, 0, 0, 0, 0);
            //swApp.ExitApp();
            //swApp = null;
        }
        public void SetMaterial(string material)
        {
            boolstatus = swModel.Extension.SelectByID2("Unknown", "BROWSERITEM", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swPart = ((PartDoc)(swModel));
            swPart.SetMaterialPropertyName2("Default", "C:/Program Files/SOLIDWORKS Corp/SOLIDWORKS/lang/english/sldmaterials/SOLIDWORKS Materials.sldmat", material);
            swModel.ClearSelection2(true);
            swModel.SaveAs4(place, 0, 0, 0, 0);
        }
        public string[] GetMassProperties()
        {
            string db = "C:/PROGRA~1/SOLIDW~1/SOLIDW~1/lang/english/sldmaterials/SolidWorks Materials.sldmat";
            string[] mass = new string[4];
            mass[0] = (Math.Round(swModel.Extension.CreateMassProperty().Mass * 1000, 2)).ToString();
            mass[1] = (Math.Round(swModel.Extension.CreateMassProperty().SurfaceArea * 1000000, 2)).ToString();
            mass[2] = (Math.Round(swModel.Extension.CreateMassProperty().Volume * 1000000000, 2)).ToString();
            mass[3] = swPart.GetMaterialPropertyName2("Default", out db);
            return mass;
        }
        public void ChangeDimensions()
        {
            swApp.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swInputDimValOnCreate)), false);

            myDimension = swModel.Parameter("D2@Sketch1"); // 69 A
            myDimension.SystemValue = newNutDim[0] / 1000;

            myDimension = swModel.Parameter("D1@Sketch1"); // 37 B
            myDimension.SystemValue = newNutDim[1] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude1"); // 25 C
            myDimension.SystemValue = newNutDim[2] / 1000;

            myDimension = swModel.Parameter("D1@Sketch2"); // 8 D
            myDimension.SystemValue = newNutDim[3] / 1000;

            myDimension = swModel.Parameter("D2@Sketch2"); // 8 D
            myDimension.SystemValue = newNutDim[3] / 1000;

            myDimension = swModel.Parameter("D3@Sketch2"); // 8 D
            myDimension.SystemValue = newNutDim[3] / 1000;

            swApp.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swInputDimValOnCreate)), true);

            swModel.Rebuild(0);
            swModel.SaveAs4(place, 0, 0, 0, 0);
        }
        public void OpenPart(string place)
        {
            object processSW = System.Activator.CreateInstance(System.Type.GetTypeFromProgID("SldWorks.Application"));
            swApp = (SldWorks)processSW;
            swApp.Visible = true;

            swModel = ((ModelDoc2)(swApp.OpenDoc6(place, 1, 0, "", ref longstatus, ref longstatus)));
        }
        public void SavePart()
        {
            swModel.SaveAs4(place, 0, 0, 0, 0);
        }
        public void SavePart(string place)
        {
            swModel.SaveAs4(place, 0, 0, 0, 0);
        }
    }
}
