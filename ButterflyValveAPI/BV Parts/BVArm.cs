using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVArm : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempArm.SLDPRT";

        #endregion

        #region Fields

        private SldWorks _swApp;
        private ModelDoc2 _swModel;
        private PartDoc _swPart;
        private DisplayDimension _myDisplayDim;
        private Dimension _myDimension;
        private bool _boolStatus;
        private int _longStatus;

        #endregion

        #region Properties

        public double[] NewArmDim
        {
            get;
            set;
        }

        #endregion

        #region IButterflyValve Members

        public void CreatePart()
        {
            var processes = Process.GetProcessesByName( "SLDWORKS" );
            foreach ( var process in processes )
            {
                process.CloseMainWindow();
                process.Kill();
            }

            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );
            _swApp = (SldWorks) processSW;
            _swApp.Visible = true;

            _swModel = _swApp.NewDocument( "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2015\\templates\\Part.prtdot", 0, 0, 0 );
            _swApp.ActivateDoc2( "Part1", false, _longStatus );

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, false );

            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, -0.039268, 0.000778, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -3.92684032240151E-02, 0, 3.11036857219921E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -9.79766100242753E-02, 0, 3.88796071524894E-04 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.1125;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterLine( 0, 0, 0, 0, 0.248062, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.248062, 0, 0.045732, 0.248062, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 4.98895841584159E-02, 0, -0.24113299009901, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.200944158415842, 0, -0.238361346534654 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.0438;
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.248062, 0, -0.080378, 0.250834, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc3", "SKETCHSEGMENT", -7.89918415841585E-02, 0, -0.248062099009901, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -0.153826217821782, 0, -0.24113299009901 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch1" );
            _myDimension.SystemValue = 0.0875;
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -1.38582178217828E-03, 0, -0.137196356435644, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.119180673267327, 0, -0.123338138613861 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch1" );
            _myDimension.SystemValue = 0.3;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 6, 0, 0.0625, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Boss-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterRectangle( 0, 4.34805391855773E-02, 0, 9.97724946975427E-03, 3.93824484366968E-02, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", -1.44773079985176E-03, 0, -0.047206076230014, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -3.9314221628096E-03, 0, -6.08663787262821E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D5@Sketch1" );
            _myDimension.SystemValue = 0.0126;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line4", "SKETCHSEGMENT", 2.27780624458498E-03, 0, -3.93824484366968E-02, false, 0, null, 0 );
            _swModel.EditDelete();
            _swModel.SketchManager.CreateArc( 0, 0, 0, -0.0063, 0.039382, 0, 0.007884, 0.039096, 0, 1 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point8", "SKETCHPOINT", 0.0063, 3.93824484366968E-02, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point12", "SKETCHPOINT", 7.88352611531733E-03, 3.90962563534949E-02, 0, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgMERGEPOINTS" );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc4", "SKETCHSEGMENT", 3.46373067891028E-02, 0, 2.29868073606712E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 9.78238647437248E-02, 0, 5.23552075367631E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D6@Sketch1" );
            _myDimension.SystemValue = 0.02815;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point9", "SKETCHPOINT", -0.0063, 4.06946536397122E-02, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -7.88315120730705E-02, 0, -2.15107686637105E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D7@Sketch1" );
            _myDimension.SystemValue = 0.035;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.Create3PointArc( -0.05625, 0, 0, 0.05625, 0, 0, 0.001884, 0.055368, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.Create3PointArc( -0.04375, 0.3, 0, 0.04375, 0.3, 0, 0.002407, 0.255841, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.05625, 0, 0, -0.04375, 0.3, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0.04375, 0.3, 0, 0.05625, 0, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc3", "SKETCHSEGMENT", -7.17739787867921E-03, 0, -0.254346956492355, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -4.75967651023876E-02, 0, -0.212310814579698, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -1.76864333568434E-02, 0.03125, -0.051441733029339, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -5.40638638581811E-02, 0, -7.56933533635638E-02, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 4.94097162345125E-02, 0, -0.103178523075686, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 1.46490604221233E-02, 0.03125, -5.46752824072356E-02, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 5.42600403013576E-02, 0, -7.00346419522446E-02, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc3", "SKETCHSEGMENT", 2.03077718334425E-02, 0, -0.255963731181303, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 0.04698455420109, 0, -0.215544363957595, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 6, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );

            _boolStatus = _swModel.Extension.SelectByID2( "Boss-Extrude2", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -4.32195725641391E-02, 0, -0.222185520579364, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", -0.022410148736961, 0.03125, -0.263004005778829, true, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -5.04228346581623E-02, 0, -0.20377718411686, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", -0.022410148736961, 0.03125, -0.262203643323937, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 0.046421022383705, 0, -0.206178271481534, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 8.00362454891468E-03, 0.03125, -0.255800743684806, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 6.40289963913177E-03, 0, -0.255000381229914, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.152068866429379, 0, -0.212581171120666 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.04375;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 1.60072490978294E-02, 0, -0.255000381229914, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "EDGE", 3.52159480152245E-02, 0.03125, -0.327033002170146, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 1.92086989173952E-02, 0.03125, -5.09079552325902E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.172878290256557, 0, -5.41094050521558E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch2" );
            _myDimension.SystemValue = 0.05625;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -3.20144981956583E-03, 0.03125, -5.33090425972646E-02, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "EDGE", 2.88130483760928E-02, 0.03125, 4.99377140837346E-02, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, true );

            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void SetMaterial( string material )
        {
            _boolStatus = _swModel.Extension.SelectByID2( "Unknown", "BROWSERITEM", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swPart = (PartDoc) _swModel;
            _swPart.SetMaterialPropertyName2( "Default", "C:/Program Files/SOLIDWORKS Corp/SOLIDWORKS/lang/english/sldmaterials/SOLIDWORKS Materials.sldmat", material );
            _swModel.ClearSelection2( true );
            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public string[] GetMassProperties()
        {
            var db = "C:/PROGRA~1/SOLIDW~1/SOLIDW~1/lang/english/sldmaterials/SolidWorks Materials.sldmat";
            var mass = new string[4];
            mass[0] = Math.Round( _swModel.Extension.CreateMassProperty().Mass * 1000, 2 ).ToString();
            mass[1] = Math.Round( _swModel.Extension.CreateMassProperty().SurfaceArea * 1000000, 2 ).ToString();
            mass[2] = Math.Round( _swModel.Extension.CreateMassProperty().Volume * 1000000000, 2 ).ToString();
            mass[3] = _swPart.GetMaterialPropertyName2( "Default", out db );

            return mass;
        }

        public void ChangeDimensions()
        {
            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, false );

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 112.5 A
            _myDimension.SystemValue = NewArmDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 43.8 C
            _myDimension.SystemValue = NewArmDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch1" ); // 87.5 D
            _myDimension.SystemValue = NewArmDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D5@Sketch1" ); // 12.6 E
            _myDimension.SystemValue = NewArmDim[4] / 1000;

            _myDimension = _swModel.Parameter( "D6@Sketch1" ); // 28.15 B
            _myDimension.SystemValue = NewArmDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // dim D:2
            _myDimension.SystemValue = NewArmDim[3] / 2000;

            _myDimension = _swModel.Parameter( "D2@Sketch2" ); // dim  A:2
            _myDimension.SystemValue = NewArmDim[0] / 2000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 62.5 F
            _myDimension.SystemValue = NewArmDim[5] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude2" ); // 25 G
            _myDimension.SystemValue = NewArmDim[6] / 1000;

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, true );

            _swModel.Rebuild( 0 );
            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void OpenPart( string place )
        {
            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );
            _swApp = (SldWorks) processSW;
            _swApp.Visible = true;

            _swModel = (ModelDoc2) _swApp.OpenDoc6( place, 1, 0, string.Empty, ref _longStatus, ref _longStatus );
        }

        public void SavePart()
        {
            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void SavePart( string place )
        {
            _swModel.SaveAs4( place, 0, 0, 0, 0 );
        }

        #endregion
    }
}