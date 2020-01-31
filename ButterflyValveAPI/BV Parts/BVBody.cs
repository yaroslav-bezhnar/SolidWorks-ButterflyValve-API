using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVBody : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempBody.SLDPRT";

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

        public double[] NewBodyDim
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
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.035769, -0.000389, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 0.035769238580291, 0, 9.33110571659763E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 8.24247671632792E-02, 0, 5.05434892982372E-03 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.194;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.170804, -0.001054, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 0.167641304347826, 0, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.336336956521739, 0, -3.16304347826085E-03 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.28;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 6, 0, 0.225, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.056726, -0.00045, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 5.35742618242975E-02, -0.018008155235058, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 9.00407761752899E-02, -6.75305821314673E-03, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.2;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -7.82183414432325E-02, 8.53232697975841E-02, 0.116111545773208, false, 1, null, 0 );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, true, 4, 0, 0.225, 0.225, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 3, 0.16, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -2.18127948348297E-02, -1.00313672587617E-02, 0.160000000000025, true, 0, null, 0 );
            _swModel.FeatureManager.InsertRefPlane( 264, 0.325, 0, 0, 0, 0 );
            _swModel.ClearSelection2( true );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.BlankRefGeom();
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.02251, -0.00045, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 2.43110095673283E-02, -3.15142716613515E-03, 9.99999999999999E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 4.81718152537801E-02, -3.60163104701281E-03, -0.165 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch3" );
            _myDimension.SystemValue = 0.075;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 2, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 1.26056604277096E-02, -2.07907239353631E-02, 0.160000000000025, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.036016, 0.002251, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.73669221127453E-02, -4.95224268964092E-03, -2.49999999999997E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 7.02318054167261E-02, 4.502038808776E-04, 0.16 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch4" );
            _myDimension.SystemValue = 0.0562;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureCut3( true, false, false, 0, 0, 0.31, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -6.41139082625841E-02, 4.21878037205374E-02, 0.159999999999968, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.051323, -0.019359, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 5.49248734669269E-02, -2.25101940438224E-03, -2.49999999999999E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 7.11322131784791E-02, -9.0040776175174E-04, 0.16 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch5" );
            _myDimension.SystemValue = 0.1;
            _swModel.SetPickMode();
            _swModel.FeatureManager.FeatureCut3( true, false, false, 0, 0, 0.025, 0.31, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -0.039488253255854, 6.39726379276908E-02,
                                                       0.160000000000025, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.085989, 0, 0.005402, 0.078786, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 0, 9.45428149840544E-02, -2.50000000000066E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -1.62073397115525E-03, 0.125336760436005, 0.16 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch6" );
            _myDimension.SystemValue = 0.0203;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point1@Origin", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.24146794231045E-03, 7.83354752725023E-02, -2.50000000000055E-03, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -6.32086248750536E-02, 4.53805511923473E-02, 0.16 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch6" );
            _myDimension.SystemValue = 0.075;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.78171259936216E-03, 6.59098481603134E-02, 0.160000000000025, false, 0, null, 0 );
            _boolStatus =
                _swModel.SketchManager.CreateCircularSketchStepAndRepeat( 0.075, 4.71238898038473, 3, 2.0943951023932, true, string.Empty, false, false, true );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.78171259936216E-03, 6.59098481603134E-02, 0.160000000000025, false, 0, null, 0 );
            _swModel.FeatureManager.FeatureCut3( true, false, false, 0, 0, 0.015, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false,
                                               false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 9.44118221418648E-02, 0.112500000000011, -6.56582899775344E-02, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterLine( 0, 0, 0, 0, 0.188224, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", 3.12141357407669E-03, 0, -6.41479180880152E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.166995626213104, 0.1125, -7.97549859583995E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch7" );
            _myDimension.SystemValue = 0.175;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateArc( 0, 0.175, 0, -0.076475, 0.175, 0, 0.076475, 0.175, 0, -1 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 7.33532189908028E-02, 0, -0.192125874625161, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.140463610833452, 0.1125, -0.196807994986276 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch7" );
            _myDimension.SystemValue = 0.05;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.05, 0.175, 0, -0.05, 0.115651, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0.05, 0.175, 0, 0.05, 0.120333, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", -4.68212036111508E-02, 0, -0.15466891173624, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line3", "SKETCHSEGMENT", 5.07229705787466E-02, 0, -0.147645731194567, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgSAMELENGTH" );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", -5.30640307593042E-02, 0, -0.166374212639028, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -0.137342197259376, 0.1125, -0.148426084588087 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch7" );
            _myDimension.SystemValue = 0.06;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.05, 0.115, 0, 0.05, 0.115, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.175, 0, 0.009455, 0.171363, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 9.45506974329666E-03, 4.99999999998863E-05, -0.178997721913844, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 3.28782550005425E-02, 0.1125, -0.191143077232416 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch7" );
            _myDimension.SystemValue = 0.047;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, true, 0, 0, 0.032, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Right Plane", "PLANE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.InsertAxis2( true );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Boss-Extrude4", "BODYFEATURE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, false, 0, null, 0 );
            _swModel.BlankRefGeom();
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Boss-Extrude4", "BODYFEATURE", 0, 0, 0, true, 0, null, 0 );
            _swModel.ActivateSelectedFeature();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Boss-Extrude4", "BODYFEATURE", 0, 0, 0, false, 4, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, true, 1, null, 0 );
            _swModel.FeatureManager.FeatureCircularPattern4( 3, 6.2831853071796, false, "NULL", false, true, false );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "CirPattern1", "BODYFEATURE", 0, 0, 0, true, 0, null, 0 );

            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 2, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "CirPattern1", "BODYFEATURE", 0, 0, 0, true, 1, null, 0 );

            _swModel.FeatureManager.InsertMirrorFeature( false, false, false, false );
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, true );

            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void SetMaterial( string material )
        {
            _boolStatus = _swModel.Extension.SelectByID2( "Unknown", "BROWSERITEM", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swPart = (PartDoc) ( _swModel );
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

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 194 A
            _myDimension.SystemValue = NewBodyDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 280 B
            _myDimension.SystemValue = NewBodyDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 225 C
            _myDimension.SystemValue = NewBodyDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // 200 D
            _myDimension.SystemValue = NewBodyDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D19@Boss-Extrude2" ); // 160 E
            _myDimension.SystemValue = NewBodyDim[4] / 1000;

            _myDimension = _swModel.Parameter( "D1@Plane1" ); // 325 F
            _myDimension.SystemValue = NewBodyDim[5] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch3" ); // 75 G
            _myDimension.SystemValue = NewBodyDim[6] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch4" ); // 56.2 H
            _myDimension.SystemValue = NewBodyDim[7] / 1000;

            _myDimension = _swModel.Parameter( "D1@Cut-Extrude1" ); // 310 I
            _myDimension.SystemValue = NewBodyDim[8] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch5" ); // 100 J
            _myDimension.SystemValue = NewBodyDim[9] / 1000;

            _myDimension = _swModel.Parameter( "D1@Cut-Extrude2" ); // 25 K
            _myDimension.SystemValue = NewBodyDim[10] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch6" ); // 75 L
            _myDimension.SystemValue = NewBodyDim[11] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch6" ); // 20.3 M
            _myDimension.SystemValue = NewBodyDim[12] / 1000;

            _myDimension = _swModel.Parameter( "D1@Cut-Extrude3" ); // 15 N
            _myDimension.SystemValue = NewBodyDim[13] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch7" ); // 175 O
            _myDimension.SystemValue = NewBodyDim[14] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch7" ); // 60 P
            _myDimension.SystemValue = NewBodyDim[15] / 1000;

            _myDimension = _swModel.Parameter( "D4@Sketch7" ); // 47 Q
            _myDimension.SystemValue = NewBodyDim[16] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch7" ); // 50 R
            _myDimension.SystemValue = NewBodyDim[17] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude4" ); // 32 S
            _myDimension.SystemValue = NewBodyDim[18] / 1000;

            _myDimension = _swModel.Parameter( "D1@CirPattern1" ); // 3 T
            _myDimension.SystemValue = NewBodyDim[19];

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