using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVNut : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempNut.SLDPRT";

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

        public double[] NewNutDim
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

            _swApp.ActivateDoc2( "Part7", false, _longStatus );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.011275, 0.005443, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 1.36078625033716E-02, 0, 3.88796071524894E-04, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 5.44314500134863E-02, 0, 7.77592143049802E-04 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.037;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SetPickMode();
            _swModel.SketchManager.CreatePolygon( 0, 0, 0, 5.17040853292076E-02, 0, 0, 6, true );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", -4.42357174483221E-02, 0, -1.14897967398239E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -9.70887824515121E-02, 0, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.069;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 6, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );

            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.039837, 0.0125, 0, -0.035194, 0.0125, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateLine( -0.039837, 0.0125, 0, -0.039837, 0.009392, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.Create3PointArc( -0.039837, 0.009392, 0, -0.035194, 0.0125, 0, -0.037611, 0.011406, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Right Plane", "PLANE", 0, 0, 0, true, 0, null, 0 );
            _boolStatus = _swModel.InsertAxis2( true );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, false, 0, null, 0 );
            _swModel.BlankRefGeom();
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0 );
            _swModel.EditSketch();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -3.72688966976747E-02, 1.25081999398274E-02, 4.44837737757098E-03, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -3.74111865665304E-02, 0.012275361972609, 4.20192409535503E-03, true, 0, null, 0 );
            _swModel.SketchAddConstraints( "sgTANGENT" );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );

            _boolStatus = _swModel.Extension.SelectByID2( "Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0 );
            _swModel.EditSketch();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Front Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line2", "SKETCHSEGMENT", -3.98057597530716E-02, 1.08657361303514E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -4.35906778009545E-02, 1.11083590821388E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.008;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Line1", "SKETCHSEGMENT", -3.78162515484152E-02, 1.24185230217906E-02, 3.50033096617608E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -3.75736285966278E-02, 0.016057867298601, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch2" );
            _myDimension.SystemValue = 0.008;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -3.86896941748497E-02, 1.32919656482251E-02, 0, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -4.49978909213212E-02, 1.64945886118183E-02, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch2" );
            _myDimension.SystemValue = 0.008;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.InsertSketch( true );

            _boolStatus = _swModel.Extension.SelectByID2( "Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, true, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Axis1", "AXIS", 0, 0, 0, true, 16, null, 0 );
            _swModel.FeatureManager.FeatureRevolve2( true, true, false, true, false, false, 0, 0, 6.2831853071796, 0, false, false, 0.01, 0.01, 0, 0, 0, true, true, true );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );

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

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 69 A
            _myDimension.SystemValue = NewNutDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 37 B
            _myDimension.SystemValue = NewNutDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 25 C
            _myDimension.SystemValue = NewNutDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // 8 D
            _myDimension.SystemValue = NewNutDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch2" ); // 8 D
            _myDimension.SystemValue = NewNutDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch2" ); // 8 D
            _myDimension.SystemValue = NewNutDim[3] / 1000;

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