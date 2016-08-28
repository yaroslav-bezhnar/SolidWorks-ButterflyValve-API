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
    class BVArm: IButterflyValve
    {
        public string place = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempArm.SLDPRT";

        SldWorks swApp;
        ModelDoc2 swModel;
        PartDoc swPart;
        DisplayDimension myDisplayDim;
        Dimension myDimension;
        bool boolstatus;
        int longstatus = 0;
        public double[] newArmDim;

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
            swModel.SketchManager.CreateCircle(0, 0, 0, -0.039268, 0.000778, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -3.92684032240151E-02, 0, 3.11036857219921E-03, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-9.79766100242753E-02, 0, 3.88796071524894E-04);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch1");
            myDimension.SystemValue = 0.1125;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCenterLine(0, 0, 0, 0, 0.248062, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0.248062, 0, 0.045732, 0.248062, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 4.98895841584159E-02, 0, -0.24113299009901, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.200944158415842, 0, -0.238361346534654);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch1");
            myDimension.SystemValue = 0.0438;
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCircle(0, 0.248062, 0, -0.080378, 0.250834, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", -7.89918415841585E-02, 0, -0.248062099009901, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-0.153826217821782, 0, -0.24113299009901);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D3@Sketch1");
            myDimension.SystemValue = 0.0875;
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -1.38582178217828E-03, 0, -0.137196356435644, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.119180673267327, 0, -0.123338138613861);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D4@Sketch1");
            myDimension.SystemValue = 0.3;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Trimetric", 8);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 6, 0, 0.0625, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Boss-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.FeatEdit();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateCenterRectangle(0, 4.34805391855773E-02, 0, 9.97724946975427E-03, 3.93824484366968E-02, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", -1.44773079985176E-03, 0, -0.047206076230014, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-3.9314221628096E-03, 0, -6.08663787262821E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D5@Sketch1");
            myDimension.SystemValue = 0.0126;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line4", "SKETCHSEGMENT", 2.27780624458498E-03, 0, -3.93824484366968E-02, false, 0, null, 0);
            swModel.EditDelete();
            swModel.SketchManager.CreateArc(0, 0, 0, -0.0063, 0.039382, 0, 0.007884, 0.039096, 0, 1);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Point8", "SKETCHPOINT", 0.0063, 3.93824484366968E-02, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point12", "SKETCHPOINT", 7.88352611531733E-03, 3.90962563534949E-02, 0, true, 0, null, 0);
            swModel.SketchAddConstraints("sgMERGEPOINTS");
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc4", "SKETCHSEGMENT", 3.46373067891028E-02, 0, 2.29868073606712E-02, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(9.78238647437248E-02, 0, 5.23552075367631E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D6@Sketch1");
            myDimension.SystemValue = 0.02815;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Point9", "SKETCHPOINT", -0.0063, 4.06946536397122E-02, 0, true, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(-7.88315120730705E-02, 0, -2.15107686637105E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D7@Sketch1");
            myDimension.SystemValue = 0.035;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.InsertSketch(true);
            swModel.ShowNamedView2("*Isometric", 7);

            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.SketchManager.InsertSketch(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.Create3PointArc(-0.05625, 0, 0, 0.05625, 0, 0, 0.001884, 0.055368, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.Create3PointArc(-0.04375, 0.3, 0, 0.04375, 0.3, 0, 0.002407, 0.255841, 0);
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(-0.05625, 0, 0, -0.04375, 0.3, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            swModel.SketchManager.CreateLine(0.04375, 0.3, 0, 0.05625, 0, 0);
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", -7.17739787867921E-03, 0, -0.254346956492355, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -4.75967651023876E-02, 0, -0.212310814579698, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -1.76864333568434E-02, 0.03125, -0.051441733029339, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -5.40638638581811E-02, 0, -7.56933533635638E-02, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 4.94097162345125E-02, 0, -0.103178523075686, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 1.46490604221233E-02, 0.03125, -5.46752824072356E-02, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 5.42600403013576E-02, 0, -7.00346419522446E-02, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc3", "SKETCHSEGMENT", 2.03077718334425E-02, 0, -0.255963731181303, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.04698455420109, 0, -0.215544363957595, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.ClearSelection2(true);
            swModel.ClearSelection2(true);
            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 6, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false);
            swModel.SelectionManager.EnableContourSelection = false;
            swModel.ClearSelection2(true);

            boolstatus = swModel.Extension.SelectByID2("Boss-Extrude2", "BODYFEATURE", 0, 0, 0, false, 0, null, 0);
            swModel.FeatEdit();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -4.32195725641391E-02, 0, -0.222185520579364, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", -0.022410148736961, 0.03125, -0.263004005778829, true, 0, null, 0);
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line1", "SKETCHSEGMENT", -5.04228346581623E-02, 0, -0.20377718411686, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", -0.022410148736961, 0.03125, -0.262203643323937, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Line2", "SKETCHSEGMENT", 0.046421022383705, 0, -0.206178271481534, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 8.00362454891468E-03, 0.03125, -0.255800743684806, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 6.40289963913177E-03, 0, -0.255000381229914, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.152068866429379, 0, -0.212581171120666);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D1@Sketch2");
            myDimension.SystemValue = 0.04375;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc2", "SKETCHSEGMENT", 1.60072490978294E-02, 0, -0.255000381229914, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("", "EDGE", 3.52159480152245E-02, 0.03125, -0.327033002170146, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", 1.92086989173952E-02, 0.03125, -5.09079552325902E-02, false, 0, null, 0);
            myDisplayDim = swModel.AddDimension2(0.172878290256557, 0, -5.41094050521558E-02);
            swModel.ClearSelection2(true);
            myDimension = swModel.Parameter("D2@Sketch2");
            myDimension.SystemValue = 0.05625;
            swModel.SetPickMode();
            swModel.ClearSelection2(true);
            boolstatus = swModel.Extension.SelectByID2("Arc1", "SKETCHSEGMENT", -3.20144981956583E-03, 0.03125, -5.33090425972646E-02, false, 0, null, 0);
            boolstatus = swModel.Extension.SelectByID2("", "EDGE", 2.88130483760928E-02, 0.03125, 4.99377140837346E-02, true, 0, null, 0);
            swModel.SketchAddConstraints("sgTANGENT");
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

            myDimension = swModel.Parameter("D1@Sketch1"); // 112.5 A
            myDimension.SystemValue = newArmDim[0] / 1000;

            myDimension = swModel.Parameter("D2@Sketch1"); // 43.8 C
            myDimension.SystemValue = newArmDim[2] / 1000;

            myDimension = swModel.Parameter("D3@Sketch1"); // 87.5 D
            myDimension.SystemValue = newArmDim[3] / 1000;

            myDimension = swModel.Parameter("D5@Sketch1"); // 12.6 E
            myDimension.SystemValue = newArmDim[4] / 1000;

            myDimension = swModel.Parameter("D6@Sketch1"); // 28.15 B
            myDimension.SystemValue = newArmDim[1] / 1000;

            myDimension = swModel.Parameter("D1@Sketch2");  // dim D:2
            myDimension.SystemValue = newArmDim[3] / 2000;

            myDimension = swModel.Parameter("D2@Sketch2"); // dim  A:2
            myDimension.SystemValue = newArmDim[0] / 2000;

            myDimension = swModel.Parameter("D1@Boss-Extrude1"); // 62.5 F
            myDimension.SystemValue = newArmDim[5] / 1000;

            myDimension = swModel.Parameter("D1@Boss-Extrude2");  // 25 G
            myDimension.SystemValue = newArmDim[6] / 1000;

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
