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
    class BVScrew: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newScrewDim;

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

            swApp.ActivateDoc2("Part2", false, longstatus);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0, 0, 0, 0, 0.077759, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0, 0, 0, 0.022161, 0, 0);
            swModel.SketchManager.CreateLine(0.022161, 0, 0, 0.022161, 0.050155, 0);
            swModel.SketchManager.CreateLine(0.022161, 0.050155, 0, 0.029937, 0.050155, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.012052678217272, -7.77592143049802E-04, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(1.36078625033716E-02, -2.79933171497929E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.01;
            boolstatus = swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 1.03508771929824E-02, 7.19298245614034E-03, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(1.89473684210526E-02, 6.49122807017543E-03, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.038;
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", 0, 1.96491228070175E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-1.40350877192982E-02, 1.78947368421052E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch1");
            myDimension.SystemValue = 0.053;
            boolstatus = swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 1.21052631578947E-02, 3.82456140350877E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(1.28070175438596E-02, 3.24561403508772E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D4@Sketch1");
            myDimension.SystemValue = 0.005;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.Create3PointArc(0.015, 0.038, 0, 0, 0.053, 0, 0.009815, 0.047177, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 9.46829729178948E-03, 0.046310674600421, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(2.81892055528421E-02, 5.48044200151579E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D5@Sketch1");
            myDimension.SystemValue = 0.015;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -1.52817875687634E-03, 3.07362080801294E-02, -2.61906935339539E-03, true, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -1.52817875687634E-03, 3.07362080801294E-02, -2.61906935339539E-03, false, 16, null, 0);
            swModel.FeatureManager.FeatureRevolve2(true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.042223, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0, 0.042223, 0, -0.003413, 0.042223, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0, 0.042223, 0, 0.003697, 0.042223, 0);
            swModel.SketchManager.CreateLine(0.003697, 0.042223, 0, 0.003697, 0.092804, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.003413, 0.042223, 0, -0.003413, 0.092804, 0);
            swModel.SketchManager.CreateLine(-0.003413, 0.092804, 0, 0.003697, 0.092804, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0);
            swModel.FeatureManager.FeatureCut3(false, false, false, 9, 1, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Cut-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.FeatEdit();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -1.85692093159384E-04, 2.56044855661507E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(2.89679665328616E-02, 2.46760251003538E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch2");
            myDimension.SystemValue = 0.041;
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -1.35530043896374E-03, 4.09041358004987E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-1.57363536098668E-03, 3.93360940877885E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch2");
            myDimension.SystemValue = 0.002;
            boolstatus = swModel.Extension.SelectByID2("Line3", "SKETCHSEGMENT", 1.76093435718193E-03, 4.09438330590483E-02, 0, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(1.76093435718193E-03, 3.96338235269107E-02, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch2");
            myDimension.SystemValue = 0.002;
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("", "EDGE", -5.42229401020222E-04, 2.47038364193486E-04, 9.77035399608894E-03, true, 0, null, 0);
            swModel.FeatureManager.InsertFeatureChamfer(4, 1, 0.003, 0.78539816339745, 0, 0, 0, 0);
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

            myDimension = swModel.Parameter("D1@Sketch1"); // 10 A
            myDimension.SystemValue = newScrewDim[0] / 1000;

            myDimension = swModel.Parameter("D2@Sketch1"); // 38 B
            myDimension.SystemValue = newScrewDim[1] / 1000;

            myDimension = swModel.Parameter("D4@Sketch1"); // 5 C
            myDimension.SystemValue = newScrewDim[2] / 1000;

            myDimension = swModel.Parameter("D3@Sketch1"); // 53 D
            myDimension.SystemValue = newScrewDim[3] / 1000;

            myDimension = swModel.Parameter("D5@Sketch1"); // 15 E
            myDimension.SystemValue = newScrewDim[4] / 1000;

            myDimension = swModel.Parameter("D2@Sketch2"); // 2 F
            myDimension.SystemValue = newScrewDim[5] / 1000;

            myDimension = swModel.Parameter("D3@Sketch2"); // 2 F
            myDimension.SystemValue = newScrewDim[5] / 1000;

            myDimension = swModel.Parameter("D1@Sketch2"); // 41 G
            myDimension.SystemValue = newScrewDim[6] / 1000;

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
