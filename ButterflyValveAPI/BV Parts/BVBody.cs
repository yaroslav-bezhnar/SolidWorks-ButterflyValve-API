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
    class BVBody: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempBody.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newBodyDim;

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

            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.035769, -0.000389, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0.035769238580291, 0, 9.33110571659763E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(8.24247671632792E-02, 0, 5.05434892982372E-03);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.194;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.170804, -0.001054, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 0.167641304347826, 0, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.336336956521739, 0, -3.16304347826085E-03);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.28;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 6, 0, 0.225, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.056726, -0.00045, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 5.35742618242975E-02, -0.018008155235058, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(9.00407761752899E-02, -6.75305821314673E-03, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch2");
            myDimension.SystemValue = 0.2;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("", "FACE", -7.82183414432325E-02, 8.53232697975841E-02, 0.116111545773208, false, 1, null, 0);
            swModel.FeatureManager.FeatureExtrusion2(true, false, true, 4, 0, 0.225, 0.225, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 3, 0.16, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("", "FACE", -2.18127948348297E-02, -1.00313672587617E-02, 0.160000000000025, true, 0, null, 0);
            swModel.FeatureManager.InsertRefPlane(264, 0.325, 0, 0, 0, 0);
            swModel.ClearSelection2(true);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Plane1", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.BlankRefGeom();
            boolstatus = swModel.Extension.SelectByID2("Plane1", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Plane1", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.02251, -0.00045, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 2.43110095673283E-02, -3.15142716613515E-03, 9.99999999999999E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(4.81718152537801E-02, -3.60163104701281E-03, -0.165);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch3");
            myDimension.SystemValue = 0.075;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 2, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("", "FACE", 1.26056604277096E-02, -2.07907239353631E-02, 0.160000000000025, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.036016, 0.002251, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 3.73669221127453E-02, -4.95224268964092E-03, -2.49999999999997E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(7.02318054167261E-02, 4.502038808776E-04, 0.16);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch4");
            myDimension.SystemValue = 0.0562;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureCut3(true, false, false, 0, 0, 0.31, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("", "FACE", -6.41139082625841E-02, 4.21878037205374E-02, 0.159999999999968, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.051323, -0.019359, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 5.49248734669269E-02, -2.25101940438224E-03, -2.49999999999999E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(7.11322131784791E-02, -9.0040776175174E-04, 0.16);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch5");
            myDimension.SystemValue = 0.1;
            swModel.SetPickMode();
            swModel.FeatureManager.FeatureCut3(true, false, false, 0, 0, 0.025, 0.31, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("", "FACE", -0.039488253255854, 6.39726379276908E-02, 0.160000000000025, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0.085989, 0, 0.005402, 0.078786, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 0, 9.45428149840544E-02, -2.50000000000066E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-1.62073397115525E-03, 0.125336760436005, 0.16);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch6");
            myDimension.SystemValue = 0.0203;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Point1@Origin", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 3.24146794231045E-03, 7.83354752725023E-02, -2.50000000000055E-03, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-6.32086248750536E-02, 4.53805511923473E-02, 0.16);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch6");
            myDimension.SystemValue = 0.075;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 3.78171259936216E-03, 6.59098481603134E-02, 0.160000000000025, false, 0, null, 0);
            boolstatus = swModel.SketchManager.CreateCircularSketchStepAndRepeat(0.075, 4.71238898038473, 3, 2.0943951023932, true, "", false, false, true);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 3.78171259936216E-03, 6.59098481603134E-02, 0.160000000000025, false, 0, null, 0);
            swModel.FeatureManager.FeatureCut3(true, false, false, 0, 0, 0.015, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("", "FACE", 9.44118221418648E-02, 0.112500000000011, -6.56582899775344E-02, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.188224, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 3.12141357407669E-03, 0, -6.41479180880152E-02, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.166995626213104, 0.1125, -7.97549859583995E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch7");
            myDimension.SystemValue = 0.175;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateArc(0, 0.175, 0, -0.076475, 0.175, 0, 0.076475, 0.175, 0, -1);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 7.33532189908028E-02, 0, -0.192125874625161, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.140463610833452, 0.1125, -0.196807994986276);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch7");
            myDimension.SystemValue = 0.05;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.05, 0.175, 0, -0.05, 0.115651, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.05, 0.175, 0, 0.05, 0.120333, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -4.68212036111508E-02, 0, -0.15466891173624, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 5.07229705787466E-02, 0, -0.147645731194567, true, 0, null, 0);
            swModel.SketchAddConstraints("sgSAMELENGTH");
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -5.30640307593042E-02, 0, -0.166374212639028, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-0.137342197259376, 0.1125, -0.148426084588087);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch7");
            myDimension.SystemValue = 0.06;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.05, 0.115, 0, 0.05, 0.115, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0.175, 0, 0.009455, 0.171363, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 9.45506974329666E-03, 4.99999999998863E-05, -0.178997721913844, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(3.28782550005425E-02, 0.1125, -0.191143077232416);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D4@Sketch7");
            myDimension.SystemValue = 0.047;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, true, 0, 0, 0.032, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Right Plane", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.InsertAxis2(true);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Boss-Extrude4", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, false, 0, null, 0);
            swModel.BlankRefGeom();
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Boss-Extrude4", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);
            swModel.ActivateSelectedFeature();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Boss-Extrude4", "BODYFEATURE", 0, 0, 0, false, 4, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Axis1", "AXIS", 0, 0, 0, true, 1, null, 0);
            swModel.FeatureManager.FeatureCircularPattern4(3, 6.2831853071796, false, "NULL", false, true, false);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, true, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("CirPattern1", "BODYFEATURE", 0, 0, 0, true, 0, null, 0);

            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 2, null, 0);
            boolstatus = swModel.Extension.SelectByID2("CirPattern1", "BODYFEATURE", 0, 0, 0, true, 1, null, 0);

            swModel.FeatureManager.InsertMirrorFeature(false, false, false, false);
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

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

            myDimension = swModel.Parameter("D1@Sketch1"); // 194 A
            myDimension.SystemValue = newBodyDim[0] / 1000;

            myDimension = swModel.Parameter("D2@Sketch1"); // 280 B
            myDimension.SystemValue = newBodyDim[1] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude1"); // 225 C
            myDimension.SystemValue = newBodyDim[2] / 1000;

            myDimension = swModel.Parameter("D1@Sketch2"); // 200 D
            myDimension.SystemValue = newBodyDim[3] / 1000;

            myDimension = swModel.Parameter("D19@Boss-Extrude2"); // 160 E
            myDimension.SystemValue = newBodyDim[4] / 1000;

            myDimension = swModel.Parameter("D1@Plane1"); // 325 F
            myDimension.SystemValue = newBodyDim[5] / 1000;

            myDimension = swModel.Parameter("D1@Sketch3"); // 75 G
            myDimension.SystemValue = newBodyDim[6] / 1000;

            myDimension = swModel.Parameter("D1@Sketch4"); // 56.2 H
            myDimension.SystemValue = newBodyDim[7] / 1000;

            myDimension = swModel.Parameter("D1@Cut-Extrude1"); // 310 I
            myDimension.SystemValue = newBodyDim[8] / 1000;

            myDimension = swModel.Parameter("D1@Sketch5"); // 100 J
            myDimension.SystemValue = newBodyDim[9] / 1000;

            myDimension = swModel.Parameter("D1@Cut-Extrude2"); // 25 K
            myDimension.SystemValue = newBodyDim[10] / 1000;

            myDimension = swModel.Parameter("D2@Sketch6"); // 75 L
            myDimension.SystemValue = newBodyDim[11] / 1000;

            myDimension = swModel.Parameter("D1@Sketch6"); // 20.3 M
            myDimension.SystemValue = newBodyDim[12] / 1000;

            myDimension = swModel.Parameter("D1@Cut-Extrude3"); // 15 N
            myDimension.SystemValue = newBodyDim[13] / 1000;

            myDimension = swModel.Parameter("D1@Sketch7"); // 175 O
            myDimension.SystemValue = newBodyDim[14] / 1000;

            myDimension = swModel.Parameter("D3@Sketch7"); // 60 P
            myDimension.SystemValue = newBodyDim[15] / 1000;

            myDimension = swModel.Parameter("D4@Sketch7"); // 47 Q
            myDimension.SystemValue = newBodyDim[16] / 1000;

            myDimension = swModel.Parameter("D2@Sketch7"); // 50 R
            myDimension.SystemValue = newBodyDim[17] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude4"); // 32 S
            myDimension.SystemValue = newBodyDim[18] / 1000;

            myDimension = swModel.Parameter("D1@CirPattern1"); // 3 T
            myDimension.SystemValue = newBodyDim[19];

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
