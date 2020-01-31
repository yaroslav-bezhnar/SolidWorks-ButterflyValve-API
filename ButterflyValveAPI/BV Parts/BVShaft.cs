using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVShaft : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempShaft.SLDPRT";

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

        public double[] NewShaftDim
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

            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.015941, 0, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 1.47742507179463E-02, -6.22073714439843E-03, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.055597838228061, 1.16638821457471E-03, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.0375;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, true, 0, 0, 0.0289, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 1.55265469879851E-03, 2.76688329543617E-03, -2.88999999999078E-02, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, -0.025211, 0.000225, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 2.53614852893733E-02, -2.77625726540478E-03, -0.01445, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.033014951264273, -6.002718411687E-04, -0.0289 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.056;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 0, 0, 0.0898, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 1.43813378023196E-02, -8.36063951271626E-03, -0.118699999999933, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, -0.036977, -0.00056, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.61699800614552E-02, -9.41226246952364E-03, -5.93499999999999E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 5.20363653672236E-02, -3.6304440953881E-03, -0.1187 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch3" );
            _myDimension.SystemValue = 0.0872;
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 0, 0, 0.024, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 7.50592689962559E-03, -1.07748039752664E-02, -0.142699999999991, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, -0.060555, -0.000879, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 5.95780058267477E-02, -1.02552305111615E-02, -7.13499999999999E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 7.67677255406946E-02, -8.69252871898501E-03, -0.1427 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch4" );
            _myDimension.SystemValue = 0.056;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 0, 0, 0.2471, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.011462160749204, 2.55464062239525E-02, -0.260723824398212, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, true, 1, null, 0 );
            _swModel.FeatureManager.InsertRefPlane( 32, 0, 1, 0, 0, 0 );
            _swModel.ClearSelection2( true );
            _swModel.BlankRefGeom();
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCornerRectangle( -0.028, 0.357910221368973, 0, 1.48191110335429E-02, 0.213618877095002, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", 4.67971927375044E-03, 0, -0.357910221368972, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 4.67971927375033E-03, 0.028, -0.404551423464018 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch5" );
            _myDimension.SystemValue = 0.056;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line4", "SKETCHSEGMENT", 2.71423717877523E-02, 0, -0.303469487151009, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.100145992458259, 0.028, -0.289430329329758 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch5" );
            _myDimension.SystemValue = 0.1938;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureCut3( true, false, false, 0, 0, 0.0311, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.BlankRefGeom();
            _boolStatus = _swModel.Extension.SelectByID2( "Cut-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterLine( 0.028, 0.16411, 0, 0.028, 0.1427, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line7", "SKETCHSEGMENT", 2.84911353553458E-02, 0, -0.153626143745223, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 5.38690998950853E-02, 0.028, -0.153091870807544 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch5" );
            _myDimension.SystemValue = 0.0382;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterLine( 0, 0.16411, 0, 0, 0.187341, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.187341, 0, 0.004523, 0.184881, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -4.2608647562581E-03, 0, -0.188746128905052, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -6.10017114919511E-02, 0, -0.186813778087427 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch6" );
            _myDimension.SystemValue = 0.0125;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.263483, 0, 0.004361, 0.259749, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", -6.42676735868061E-03, 0, -0.263690161058626, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -5.57996912222438E-02, 0, -0.264105059578487 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch6" );
            _myDimension.SystemValue = 0.0125;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0.18734078285587, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point8", "SKETCHPOINT", 0, 0.263482711798695, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 6.57655750972857E-02, 0, -0.224274801671747 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch6" );
            _myDimension.SystemValue = 0.1;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", 9.83320206052463E-04, 0, -0.171632477471673, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 5.98325262632609E-02, 0, -0.172528658274574 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch6" );
            _myDimension.SystemValue = 0.0469;
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureCut3( false, false, false, 9, 1, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Cut-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line7", "SKETCHSEGMENT", 3.07583392543956E-02, 0, -0.150250229653352, false, 0, null, 0 );
            _swModel.EditDelete();
            _swModel.SketchManager.CreateCenterLine( 0, 0, 0, 0, 0.16411, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line8", "SKETCHSEGMENT", 1.34345610882891E-03, 0, -9.55058637991025E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.130442109914372, 0.028, -9.14204633622184E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch5" );
            _myDimension.SystemValue = 0.1809;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line3", "SKETCHSEGMENT", -1.58357494850102E-02, 2.30917526023404E-02, -0.181109760996442, false, 0, null, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point8", "SKETCHPOINT", 0, 0.1809, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line3", "SKETCHSEGMENT", -9.87169533224111E-03, 2.62020921162502E-02, -0.180499629551856, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgCOINCIDENT" );
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );
            _swModel.SketchManager.InsertSketch( true );

            _boolStatus = _swModel.Extension.SelectByID2( "Cut-Extrude2", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Plane1", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "D4@Sketch6@Part10.SLDPRT", "DIMENSION", 0.058753218464233, 0, -0.160582058659164, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", 1.03668075464469E-03, 0.027980802222487, -0.15434243296083, false, 0, null, 0 );
            _swModel.EditDelete();
            _swModel.SketchManager.CreateCenterLine( 0, 0, 0, 0, 0.187341, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 1.29238104185092E-03, 0, -6.85087284752046E-02, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.093504821451414, 0, -7.54379870030909E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch6" );
            _myDimension.SystemValue = 0.2278;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "EDGE", 1.69266885607158E-02, 8.02878161312037E-03, 2.09043864742853E-05, true, 0, null, 0 );
            _swModel.FeatureManager.InsertFeatureChamfer( 4, 1, 0.003, 0.78539816339745, 0, 0, 0, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Unknown", "BROWSERITEM", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, true );

            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void SetMaterial( string material )
        {
            _boolStatus = _swModel.Extension.SelectByID2( "Unknown", "BROWSERITEM", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swPart = ( (PartDoc) _swModel );
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

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 37.5 A
            _myDimension.SystemValue = NewShaftDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 28.9 B
            _myDimension.SystemValue = NewShaftDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // 56 C
            _myDimension.SystemValue = NewShaftDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude2" ); // 89.8 D
            _myDimension.SystemValue = NewShaftDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch3" ); // 87.2 E
            _myDimension.SystemValue = NewShaftDim[4] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude3" ); // 24 F
            _myDimension.SystemValue = NewShaftDim[5] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch4" ); // 56 G
            _myDimension.SystemValue = NewShaftDim[6] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude4" ); // 247.1 H
            _myDimension.SystemValue = NewShaftDim[7] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch5" ); // 180.9 I
            _myDimension.SystemValue = NewShaftDim[8] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch5" ); // 193.8 J
            _myDimension.SystemValue = NewShaftDim[9] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch5" ); // 56 G
            _myDimension.SystemValue = NewShaftDim[6] / 1000;

            _myDimension = _swModel.Parameter( "D1@Cut-Extrude1" ); // 31.1 K
            _myDimension.SystemValue = NewShaftDim[10] / 1000;

            _myDimension = _swModel.Parameter( "D4@Sketch6" ); // 227.8 L
            _myDimension.SystemValue = NewShaftDim[11] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch6" ); // 12.5 M
            _myDimension.SystemValue = NewShaftDim[12] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch6" ); // 12.5 M
            _myDimension.SystemValue = NewShaftDim[12] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch6" ); // 100 N
            _myDimension.SystemValue = NewShaftDim[13] / 1000;

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