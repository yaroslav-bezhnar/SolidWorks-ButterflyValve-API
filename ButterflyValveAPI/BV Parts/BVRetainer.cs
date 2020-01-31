using System;
using System.Diagnostics;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;

namespace ButterflyValveAPI
{
    internal class BVRetainer : IButterflyValve
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempRetainer.SLDPRT";

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

        public double[] NewRetainerDim
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

            _swApp.ActivateDoc2( "Part6", false, _longStatus );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.02916, 0, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 3.07148896504673E-02, 0, 7.77592143049802E-04, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 5.52090421565361E-02, 0, 7.77592143049802E-04 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch1" );
            _myDimension.SystemValue = 0.056;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0, 0, 0.08736, 0.000747, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc2", "SKETCHSEGMENT", 8.69866666666666E-02, 0, -4.10666666666666E-03, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.13776, 0, 0 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch1" );
            _myDimension.SystemValue = 0.2;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Trimetric", 8 );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureExtrusion2( true, false, false, 0, 0, 0.025, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, true, true, true, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
            _swModel.ClearSelection2( true );
            _swModel.ShowNamedView2( "*Isometric", 7 );

            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.SketchManager.InsertSketch( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane", "PLANE", 0, 0, 0, false, 0, null, 0 );
            _swModel.ClearSelection2( true );
            _swModel.SketchManager.CreateCircle( 0, 0.072033, 0, 0.005202, 0.06723, 0 );
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", -1.20054368233719E-03, 1.24999999999995E-02, -0.078035339351918, false, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 3.60163104701161E-03, 0, -0.103646937908445 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D1@Sketch2" );
            _myDimension.SystemValue = 0.0203;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Point1@Origin", "EXTSKETCHPOINT", 0, 0, 0, false, 0, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Point2", "SKETCHPOINT", 0, 7.20326209402319E-02, 0, true, 0, null, 0 );
            _myDisplayDim = _swModel.AddDimension2( 0.124056180508177, 0, -4.08184851994647E-02 );
            _swModel.ClearSelection2( true );
            _myDimension = _swModel.Parameter( "D2@Sketch2" );
            _myDimension.SystemValue = 0.075;
            _swModel.SetPickMode();
            _swModel.ClearSelection2( true );
            _boolStatus = _swModel.Extension.SelectByID2( "Arc1", "SKETCHSEGMENT", 4.40199350190307E-03, 2.49999999999773E-02, -6.68302649834375E-02, false, 0, null, 0 );
            _boolStatus = _swModel.SketchManager.CreateCircularSketchStepAndRepeat( 0.075, 4.71238898038473, 3, 2.0943951023932, true, string.Empty, false, false, true );
            _swModel.ClearSelection2( true );
            _swModel.ClearSelection2( true );
            _swModel.FeatureManager.FeatureCut3( true, false, true, 1, 0, 0.01, 0.01, false, false, false, false, 1.74532925199433E-02, 1.74532925199433E-02, false, false, false, false, false, true, true, true, true, false, 0, 0, false );
            _swModel.SelectionManager.EnableContourSelection = false;
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

            _myDimension = _swModel.Parameter( "D2@Sketch1" ); // 200 A
            _myDimension.SystemValue = NewRetainerDim[0] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch1" ); // 56 B
            _myDimension.SystemValue = NewRetainerDim[1] / 1000;

            _myDimension = _swModel.Parameter( "D1@Boss-Extrude1" ); // 25 C
            _myDimension.SystemValue = NewRetainerDim[2] / 1000;

            _myDimension = _swModel.Parameter( "D2@Sketch2" ); // 75 D
            _myDimension.SystemValue = NewRetainerDim[3] / 1000;

            _myDimension = _swModel.Parameter( "D1@Sketch2" ); // 20.3 E
            _myDimension.SystemValue = NewRetainerDim[4] / 1000;

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