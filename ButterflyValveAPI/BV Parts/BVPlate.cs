using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVPlate : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempPlate.SLDPRT";

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

        public double[] NewPlateDim
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

            _swApp.ActivateDoc2( "Part4", false, _longStatus );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateEllipse( 0, 0, 0, 7.07608850175322E-02, 0, 0, 0, 6.49289439446586E-02, 0 );
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SetPickMode();
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point4", "SKETCHPOINT", 0, 6.49289439446586E-02, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.11974919002967, 0, -2.83821132213179E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.1025;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( -0.053398, 0, 0, -0.054626, -0.010434, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0.049102, 0, 0, 0.062605, -0.00982, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -6.38323353293414E-02, 0, 6.13772455089839E-04, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -0.190883233532934, 0, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.0125;
            _boolStatus = _swModel.Extension.SelectByID2( "Point9", "SKETCHPOINT", -5.33982035928144E-02, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -2.76197604790419E-02, 0, -3.80538922155688E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D3@Sketch1" );
            _myDimension.SystemValue = 0.05;
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 6.26047904191617E-02, 0, 4.91017964071858E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.162035928143713, 0, 1.16616766467066E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D4@Sketch1" );
            _myDimension.SystemValue = 0.0125;
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point11", "SKETCHPOINT", 4.91017964071856E-02, 0, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 3.00748502994012E-02, 0, -0.017185628742515 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D5@Sketch1" );
            _myDimension.SystemValue = 0.05;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 0, 0, 0.006, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0 );
            _swModel.EditSketch();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point5", "SKETCHPOINT", -7.07608850175322E-02, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 0, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( -9.21307423842382E-03, 0, 0.133411058355808 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D6@Sketch1" );
            _myDimension.SystemValue = 0.0969;
            _swModel.SetPickMode();
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

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 102.5 A
            _myDimension.SystemValue = NewPlateDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 12.5 D
            _myDimension.SystemValue = NewPlateDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D4@Sketch1" ); // 12.5 D
            _myDimension.SystemValue = NewPlateDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D3@Sketch1" ); // 50 C
            _myDimension.SystemValue = NewPlateDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D5@Sketch1" ); // 50 C
            _myDimension.SystemValue = NewPlateDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D6@Sketch1" ); // 96.9 B
            _myDimension.SystemValue = NewPlateDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 6 E
            _myDimension.SystemValue = NewPlateDim[4] / 1000;

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