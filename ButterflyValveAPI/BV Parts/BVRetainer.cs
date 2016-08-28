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
    class BVRetainer: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempRetainer.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newRetainerDim;

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

            swApp.ActivateDoc2("Part6", false, longstatus);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.02916, 0, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 3.07148896504673E-02, 0, 7.77592143049802E-04, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(5.52090421565361E-02, 0, 7.77592143049802E-04);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.056;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0, 0, 0.08736, 0.000747, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 8.69866666666666E-02, 0, -4.10666666666666E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.13776, 0, 0);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.2;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0.072033, 0, 0.005202, 0.06723, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -1.20054368233719E-03, 1.24999999999995E-02, -0.078035339351918, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(3.60163104701161E-03, 0, -0.103646937908445);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch2");
            myDimension.SystemValue = 0.0203;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Point1@Origin", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 7.20326209402319E-02, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.124056180508177, 0, -4.08184851994647E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch2");
            myDimension.SystemValue = 0.075;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 4.40199350190307E-03, 2.49999999999773E-02, -6.68302649834375E-02, false, 0, null, 0);
            boolstatus = swModel.SketchManager.CreateCircularSketchStepAndRepeat(0.075, 4.71238898038473, 3, 2.0943951023932, true, "", false, false, true);
            swModel.ClearSelection2(true);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureCut3(true, false, true, 1, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
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

            myDimension = swModel.Parameter("D2@Sketch1"); // 200 A
            myDimension.SystemValue = newRetainerDim[0] / 1000;

            myDimension = swModel.Parameter("D1@Sketch1"); // 56 B
            myDimension.SystemValue = newRetainerDim[1] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude1"); // 25 C
            myDimension.SystemValue = newRetainerDim[2] / 1000;

            myDimension = swModel.Parameter("D2@Sketch2"); // 75 D
            myDimension.SystemValue = newRetainerDim[3] / 1000;

            myDimension = swModel.Parameter("D1@Sketch2"); // 20.3 E
            myDimension.SystemValue = newRetainerDim[4] / 1000;

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
