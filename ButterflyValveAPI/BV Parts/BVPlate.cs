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
    class BVPlate: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempPlate.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newPlateDim;

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

            swApp.ActivateDoc2("Part4", false, longstatus);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateEllipse(0, 0, 0, 7.07608850175322E-02, 0, 0, 0, 6.49289439446586E-02, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SetPickMode();
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point4", "SKETCHPOINT", 0, 6.49289439446586E-02, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.11974919002967, 0, -2.83821132213179E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.1025;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(-0.053398, 0, 0, -0.054626, -0.010434, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0.049102, 0, 0, 0.062605, -0.00982, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -6.38323353293414E-02, 0, 6.13772455089839E-04, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-0.190883233532934, 0, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.0125;
            boolstatus = swModel.Extension.SelectByID2("Point9", "SKETCHPOINT", -5.33982035928144E-02, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-2.76197604790419E-02, 0, -3.80538922155688E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch1");
            myDimension.SystemValue = 0.05;
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 6.26047904191617E-02, 0, 4.91017964071858E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.162035928143713, 0, 1.16616766467066E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D4@Sketch1");
            myDimension.SystemValue = 0.0125;
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point11", "SKETCHPOINT", 4.91017964071856E-02, 0, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(3.00748502994012E-02, 0, -0.017185628742515);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D5@Sketch1");
            myDimension.SystemValue = 0.05;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.006, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);
            swModel.EditSketch();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Point5", "SKETCHPOINT", -7.07608850175322E-02, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-9.21307423842382E-03, 0, 0.133411058355808);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D6@Sketch1");
            myDimension.SystemValue = 0.0969;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);
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

            myDimension = swModel.Parameter("D1@Sketch1"); // 102.5 A
            myDimension.SystemValue = newPlateDim[0] / 1000;

            myDimension = swModel.Parameter("D2@Sketch1"); // 12.5 D
            myDimension.SystemValue = newPlateDim[3] / 1000;

            myDimension = swModel.Parameter("D4@Sketch1"); // 12.5 D
            myDimension.SystemValue = newPlateDim[3] / 1000;

            myDimension = swModel.Parameter("D3@Sketch1"); // 50 C
            myDimension.SystemValue = newPlateDim[2] / 1000;

            myDimension = swModel.Parameter("D5@Sketch1"); // 50 C
            myDimension.SystemValue = newPlateDim[2] / 1000;

            myDimension = swModel.Parameter("D6@Sketch1"); // 96.9 B
            myDimension.SystemValue = newPlateDim[1] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude1"); // 6 E
            myDimension.SystemValue = newPlateDim[4] / 1000;

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
