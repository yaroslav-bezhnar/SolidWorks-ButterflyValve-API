using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVScrew : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT";

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

        public double[] NewScrewDim
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

            _swApp.ActivateDoc2( "Part2", false, _longStatus );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0, 0, 0, 0, 0.077759, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0, 0, 0, 0.022161, 0, 0 );
            _swModel.SketchManager.CreateLine( 0.022161, 0, 0, 0.022161, 0.050155, 0 );
            _swModel.SketchManager.CreateLine( 0.022161, 0.050155, 0, 0.029937, 0.050155, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", 0.012052678217272, -7.77592143049802E-04, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 1.36078625033716E-02, -2.79933171497929E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.01;
            _boolStatus = _swModel.Extension.SelectByID2( "Line3", "SKETCHSEGMENT", 1.03508771929824E-02, 7.19298245614034E-03, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 1.89473684210526E-02, 6.49122807017543E-03, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.038;
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", 0, 1.96491228070175E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -1.40350877192982E-02, 1.78947368421052E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch1" );
            _myDimension.SystemValue = 0.053;
            _boolStatus = _swModel.Extension.SelectByID2( "Line4", "SKETCHSEGMENT", 1.21052631578947E-02, 3.82456140350877E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 1.28070175438596E-02, 3.24561403508772E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch1" );
            _myDimension.SystemValue = 0.005;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.Create3PointArc( 0.015, 0.038, 0, 0, 0.053, 0, 0.009815, 0.047177, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 9.46829729178948E-03, 0.046310674600421, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 2.81892055528421E-02, 5.48044200151579E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D5@Sketch1" );
            _myDimension.SystemValue = 0.015;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -1.52817875687634E-03, 3.07362080801294E-02, -2.61906935339539E-03, true, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -1.52817875687634E-03, 3.07362080801294E-02, -2.61906935339539E-03, false, 16, null, 0 );
            _swModel.FeatureManager.FeatureRevolve2( true, true, false, false, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCenterLine( 0, 0, 0, 0, 0.042223, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0, 0.042223, 0, -0.003413, 0.042223, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( 0, 0.042223, 0, 0.003697, 0.042223, 0 );
            _swModel.SketchManager.CreateLine( 0.003697, 0.042223, 0, 0.003697, 0.092804, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.003413, 0.042223, 0, -0.003413, 0.092804, 0 );
            _swModel.SketchManager.CreateLine( -0.003413, 0.092804, 0, 0.003697, 0.092804, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line6", "SKETCHSEGMENT", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatureManager.FeatureCut3( false, false, false, 9, 1, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Cut-Extrude1", "BODYFEATURE", 0, 0, 0, false, 0, null, 0 );
            _swModel.FeatEdit();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -1.85692093159384E-04, 2.56044855661507E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 2.89679665328616E-02, 2.46760251003538E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.041;
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", -1.35530043896374E-03, 4.09041358004987E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -1.57363536098668E-03, 3.93360940877885E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch2" );
            _myDimension.SystemValue = 0.002;
            _boolStatus = _swModel.Extension.SelectByID2( "Line3", "SKETCHSEGMENT", 1.76093435718193E-03, 4.09438330590483E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 1.76093435718193E-03, 3.96338235269107E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch2" );
            _myDimension.SystemValue = 0.002;
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "EDGE", -5.42229401020222E-04, 2.47038364193486E-04, 9.77035399608894E-03, true, 0, null, 0 );
            _swModel.FeatureManager.InsertFeatureChamfer( 4, 1, 0.003, 0.78539816339745, 0, 0, 0, 0 );
            _swModel.ClearSelection2( true );
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

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 10 A
            _myDimension.SystemValue = NewScrewDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 38 B
            _myDimension.SystemValue = NewScrewDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D4@Sketch1" ); // 5 C
            _myDimension.SystemValue = NewScrewDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch1" ); // 53 D
            _myDimension.SystemValue = NewScrewDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D5@Sketch1" ); // 15 E
            _myDimension.SystemValue = NewScrewDim[4] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch2" ); // 2 F
            _myDimension.SystemValue = NewScrewDim[5] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch2" ); // 2 F
            _myDimension.SystemValue = NewScrewDim[5] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // 41 G
            _myDimension.SystemValue = NewScrewDim[6] / 1000;

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