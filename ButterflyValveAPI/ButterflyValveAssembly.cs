using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using SolidWorks.Interop.cosworks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swmotionstudy;
using Microsoft.DirectX.AudioVideoPlayback;

namespace ButterflyValveAPI
{
    internal class ButterflyValveAssembly
    {
        #region Static Fields

        private const string PLACE = "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempButterflyValveAssembly.SLDASM";

        #endregion

        #region Fields

        private SldWorks _swApp;
        private PartDoc _swPart;
        private ModelDoc2 _swModel;
        private IModelDoc2 _swDoc;
        private AssemblyDoc _swAssembly;
        private Feature _swFeat;
        private bool _boolStatus;
        private int _longStatus;
        private int _longWarnings = 0;
        private int _errCode;
        private CosmosWorks _cosmosWorks = null;
        private CwAddincallback _cosmosObject = default( CwAddincallback );
        private CWModelDoc _actDoc = default( CWModelDoc );
        private CWStudyManager _studyManager = default( CWStudyManager );
        private CWStudy _study = default( CWStudy );
        private CWContactManager _contactManager = default( CWContactManager );
        private CWContactComponent _cwComponentContact = default( CWContactComponent );
        private CWLoadsAndRestraintsManager _lrManager = default( CWLoadsAndRestraintsManager );
        private CWMesh _cwMesh = default( CWMesh );
        private CWForce _cwForce = default( CWForce );
        private ArrayList _pidCollection = new ArrayList();
        private byte[] _var1;
        private object _oSelect1;
        private ModelDocExtension _swModelDocExt = default( ModelDocExtension );

        #endregion

        #region Public Methods

        public void CreateButterflyValveAssembly()
        {
            var processes = Process.GetProcessesByName("SLDWORKS");
            foreach (var process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }

            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );
            _swApp = (SldWorks) processSW;
            _swApp.Visible = true;

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, false );

            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempArm.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempBody.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempNut.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempPlate.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempRetainer.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempShaft.SLDPRT", 1, 0, string.Empty, _longStatus, _longWarnings );

            _swModel = (ModelDoc2) _swApp.NewDocument( "C:\\ProgramData\\SolidWorks\\SOLIDWORKS 2015\\templates\\Assembly.asmdot", 0, 0, 0 );
            _swApp.ActivateDoc2( "Assem8", false, _longStatus );
            _swAssembly = (AssemblyDoc) _swModel;

            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempBody.SLDPRT", 0.116877733913398, 0.20364737113128, 0.299209971967532 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempArm.SLDPRT", -0.303028554073535, 9.97215058887377E-02, 0.560815581819043 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempNut.SLDPRT", 0.184777214657515, -4.72341198474169E-05, 0.514359063003212 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempPlate.SLDPRT", 0.559625993133523, -4.38768789172173E-03, 0.328524790587835 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempRetainer.SLDPRT", -0.105832171917427, -3.54536111117341E-02, 0.572892165975645 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempShaft.SLDPRT", 0.296266291115899, -0.119572941679507, 0.548757110489532 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT", 7.04822060070001E-02, -0.15599405253306, 0.643663218710572 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT", -1.76714503904805E-02, -0.11812070175074, 0.684932822478004 );
            _boolStatus = _swAssembly.AddComponent( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempScrew.SLDPRT", 7.38504879409447E-02, -7.17551387497224E-02, 0.595016686129384 );

            _swApp.CloseDoc( "TempArm.SLDPRT" );
            _swApp.CloseDoc( "TempBody.SLDPRT" );
            _swApp.CloseDoc( "TempNut.SLDPRT" );
            _swApp.CloseDoc( "TempPlate.SLDPRT" );
            _swApp.CloseDoc( "TempRetainer.SLDPRT" );
            _swApp.CloseDoc( "TempScrew.SLDPRT" );
            _swApp.CloseDoc( "TempShaft.SLDPRT" );

            _swModel.ShowNamedView2("*Isometric", 7);

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.503932243794907, -4.28869778039598E-03, 0.325947249420665, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.291809943382077, -0.126157192654034, 0.411474934674345, true, 1, null, 0 );
            Mate2 myMate = null;
            myMate = _swAssembly.AddMate5( 1, 1, false, 0.230541312012536, 0.001, 0.001, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.60412754691049, -4.31772044788659E-03, 0.325553328131093, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.50685803153857, -0.127117446545128, 0.422921141008544, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0.14142135623731, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.560993603773511, -0.122672941679468, 0.318345593855042, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.519683180387119, -7.38768789167921E-03, 0.297829320821847, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.115285253787786, 0, 0, 0.001, 0.001, 0, 0.5235987755983,
                                          0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.677417853147148, 9.06972684896346E-03, 0.353133314953027, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.11109492249355, 0.176148842223597, 0.457727753301299, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 0, false, 0.359893887551265, 0, 0, 0.001, 0.001, 1.5707963267949,
                                          0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 8.25736771431025E-02, 0.21057046175838, 0.466709971967362, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.131642621287142, 0.167423788374833, 0.575624790587824, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.108914818620303, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.189050156433154, 0.211829312979887, 0.491709971967566, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -8.00182975146981E-02, -4.79536111117511E-02, 0.515090791745934, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.188228445215276, 0.001, 0.001, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -0.114103855551946, 2.11640636803452E-02, 0.502174424727173, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.108945868628609, 0.272314282382126, 0.481722318505888, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0.336010054047233, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.172841343461585, 0.161432178688699, 0.48898386494443, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.173445890686423, 0.160425897465529, 0.501234643975067, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 4.22265007791225E-02, 0.163156461695635, 0.489666237395511, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 4.24927656086425E-02, 0.162400396078908, 0.501714982812018, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.112056390064083, 0.269715565967374, 0.509226069707154, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 8.25464960191766E-02, -7.92529716299555E-02, 0.599954240534828, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 0, false, 0.338063270429706, 0.001, 0.001, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.145625186554071, 0.25013032495076, 0.5167099719676, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.12500183440801, 0.267261520111788, 0.633016686129452, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.116306714161852, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 7.76162232908746E-02, -0.160631285467502, 0.636655665828698, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.17519578994893, 0.158465278698202, 0.509763891235195, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 0, false, 0.339328176203302, 0, 0, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.149288209027475, 0.151069981951366, 0.51670997196743, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.183328681925389, 0.154027907381817, 0.681663218710639, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.164953246743039, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -7.71759186250165E-03, -0.124120965520547, 0.683973291131196, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.056738977526777, 0.157211147225496, 0.510236062912725, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 0, false, 0.313649085829083, 0, 0, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 6.54115610800261E-02, 0.141714042307228, 0.516709971967373, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 6.40367031653142E-02, 0.166078210069657, 0.722932822478015, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.206222850510472, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.177146219391375, 0.157142479187314, 0.510535432887139, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 7.88254495796537E-02, -0.164369367117899, 0.649175957293892, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 0, false, 0.339328176203302, 0.001, 0.001, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.125675223379858, 0.13001670967293, 0.516709971967487, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.189500705051728, 0.155289864904745, 0.681663218710639, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.16495324674304, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( "Top Plane@TempShaft-1@Assem1", "PLANE", 0, 0, 0, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( "Right Plane@TempArm-1@Assem1", "PLANE", 0, 0, 0, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0, 0.001, 0.001, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.131652358743395, 0.227432039746475, 0.564949333363131, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", -0.289258779008435, 0.177270254721179, 0.694733479811589, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0.373423544370816, 0.001, 0.001, 0.001, 0.001, 0.5235987755983, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.166017289978015, 0.214137415107871, 0.5167099719676, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 9.56068925354145E-02, 0.238561131074334, 0.253409293832107, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.263300678135423, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.144077346400536, 0.169239143680954, 0.579209971967543, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.175261889252795, -1.32889393694313E-02, 0.53854123395439, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 0, 1, false, 0.168682027930675, 0.001, 0.001, 0.001, 0.001, 1.5707963267949, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.127679930767329, 0.18832173760029, 0.596676285149158, true, 1, null, 0 );
            _boolStatus = _swModel.Extension.SelectByID2( string.Empty, "FACE", 0.169991725868726, -2.16961739016597E-03, 0.596254050338644, true, 1, null, 0 );
            myMate = _swAssembly.AddMate5( 1, 1, false, 0.227314104927527, 0, 0, 0.001, 0.001, 0, 0.5235987755983, 0.5235987755983, false, false, 0, out _longStatus );
            _swModel.ClearSelection2( true );
            _swModel.EditRebuild3();

            _swModel.ShowNamedView2( "*Isometric", 7 );

            _swApp.SetUserPreferenceToggle( ( (int) ( swUserPreferenceToggle_e.swInputDimValOnCreate ) ), true );

            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void OpenButterflyValveAssembly()
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

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, false );

            _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Temp\\TempButterflyValveAssembly.SLDASM", 2, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.ActivateDoc2( "TempButterflyValveAssembly.SLDASM", false, _longStatus );

            _swApp.SetUserPreferenceToggle( (int) swUserPreferenceToggle_e.swInputDimValOnCreate, true );
        }

        public string[] GetMassProperties()
        {
            var mass = new string[4];
            mass[0] = Math.Round( _swModel.Extension.CreateMassProperty().Mass * 1000, 2 ).ToString();
            mass[1] = Math.Round( _swModel.Extension.CreateMassProperty().SurfaceArea * 1000000, 2 ).ToString();
            mass[2] = Math.Round( _swModel.Extension.CreateMassProperty().Volume * 1000000000, 2 ).ToString();

            return mass;
        }

        public void OpenPart( string place )
        {
            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );
            _swApp = (SldWorks) processSW;
            _swApp.Visible = true;

            _swModel = (ModelDoc2) _swApp.OpenDoc6( place, 2, 0, string.Empty, ref _longStatus, ref _longStatus );
        }

        public void SavePart()
        {
            _swModel.SaveAs4( PLACE, 0, 0, 0, 0 );
        }

        public void SavePart( string place )
        {
            _swModel.SaveAs4( place, 0, 0, 0, 0 );
        }

        public void OpenSimulation()
        {
            var processes = Process.GetProcessesByName( "SLDWORKS" );
            foreach ( var process in processes )
            {
                process.CloseMainWindow();
                process.Kill();
            }

            Process.Start( "C:\\Program Files\\SOLIDWORKS Corp\\SOLIDWORKS\\SLDWORKS.exe" );
            Thread.Sleep( 15000 );
            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );

            _swApp = (SldWorks) processSW;
            _swModel = _swApp.OpenDoc6( "D:\\Універ\\ІТП-51м\\МТП\\kursova\\Butterfly Valve Assembly\\Simulation\\ButterflyValve-Simulation.SLDASM", 2, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.ActivateDoc2( "ButterflyValve-Simulation.SLDASM", false, _longStatus );
        }

        public void AssemblySimulation()
        {
            var processes = Process.GetProcessesByName( "SLDWORKS" );
            foreach ( var process in processes )
            {
                process.CloseMainWindow();
                process.Kill();
            }

            Process.Start( "C:\\Program Files\\SOLIDWORKS Corp\\SOLIDWORKS\\SLDWORKS.exe" );
            Thread.Sleep( 15000 );

            var processSW = Activator.CreateInstance( Type.GetTypeFromProgID( "SldWorks.Application" ) );
            _swApp = (SldWorks) processSW;
            _swApp.OpenDoc6( PLACE, 2, 0, string.Empty, _longStatus, _longWarnings );
            _swApp.ActivateDoc2( "TempButterflyValveAssembly.SLDASM", false, _longStatus );
            _swModel = _swApp.ActiveDoc;
            _swModel.ViewZoomtofit2();
            _swModelDocExt = (ModelDocExtension) _swModel.Extension;

            _cosmosObject = (CwAddincallback) _swApp.GetAddInObject( "SldWorks.Simulation" );
            _cosmosWorks = (CosmosWorks) _cosmosObject.CosmosWorks;
            _actDoc = (CWModelDoc) _cosmosWorks.ActiveDoc;
            _studyManager = (CWStudyManager) _actDoc.StudyManager;
            _studyManager.DeleteStudy( "Static-1" );
            _study = (CWStudy) _studyManager.CreateNewStudy( "Static-1", (int) swsAnalysisStudyType_e.swsAnalysisStudyTypeStatic, (int) swsMeshType_e.swsMeshTypeSolid, out _errCode );

            _study.ContactManager.SetGlobalContact( (int) swsContactType_e.swsContactTypeStaticNoPenetration, (int) swsMeshCompatibility_e.swsMeshCompatibiltyIncompatible );
            _lrManager = (CWLoadsAndRestraintsManager) _study.LoadsAndRestraintsManager;

            _pidCollection = PidInitializer();
            SelectByPid( "selection1", _pidCollection, ref _var1 );
            _oSelect1 = (object) _swModelDocExt.GetObjectByPersistReference3( ( _var1 ), out _errCode );
            object[] dispArray1 = { _oSelect1 };

            _lrManager.AddForce2( (int) swsForceType_e.swsForceTypeNormal, 0, ( dispArray1 ), null, out _errCode );

            _cwMesh = _study.Mesh;
            double el, tl;
            _cwMesh.Quality = 1;
            _cwMesh.GetDefaultElementSizeAndTolerance( 0, out el, out tl );
            _study.CreateMesh( 0, el, tl );

            _study.RunAnalysis();

            _swModel.ClearSelection2( true );
        }

        public void ShowMotion()
        {
            Video video = null;
            try
            {
                video = new Video( @"motion.avi" );
            }
            catch
            {
                video = null;
            }
            finally
            {
                if ( video != null ) video.Play();
            }
        }

        public ArrayList PidInitializer()
        {
            // Initialize PIDs
            var pidCollection = new ArrayList();

            // Constant
            var selection1 = "13,17,0,0,3,0,0,0,255,254,255,27,77,0,105,0,120,0,101,0,100,0,45,0,49,0,45,0,83,0,111,0,108,0,105,0,100,0,45,0,51,0,64,0,109,0,105,0,120,0,101,0,100,0,109,0,101,0,115,0,104,0,45,0,49,0,4,0,0,0,16,0,0,0,1,0,0,0,1,0,0,0,17,0,0,0,255,255,1,0,11,0,109,111,70,97,99,101,82,101,102,95,99,1,0,0,0,0,0,0,0,6,0,0,0,0,3,0,0,0,0,0,0,125,195,148,37,173,73,178,84,125,195,148,37,173,73,178,84,0,0,255,255,1,0,23,0,109,111,70,114,111,109,83,107,116,69,110,116,83,117,114,102,73,100,82,101,112,95,99,0,0,255,255,1,0,6,0,109,111,70,82,95,99,255,255,1,0,13,0,109,111,69,120,116,79,98,106,101,99,116,95,99,255,255,1,0,17,0,109,111,67,83,116,114,105,110,103,72,97,110,100,108,101,95,99,255,254,255,79,67,0,58,0,92,0,80,0,114,0,111,0,103,0,114,0,97,0,109,0,32,0,70,0,105,0,108,0,101,0,115,0,92,0,83,0,111,0,108,0,105,0,100,0,87,0,111,0,114,0,107,0,115,0,92,0,83,0,111,0,108,0,105,0,100,0,87,0,111,0,114,0,107,0,115,0,32,0,83,0,105,0,109,0,117,0,108,0,97,0,116,0,105,0,111,0,110,0,92,0,69,0,120,0,97,0,109,";
            selection1 = selection1 + "0,112,0,108,0,101,0,115,0,92,0,77,0,105,0,120,0,101,0,100,0,45,0,49,0,45,0,83,0,111,0,108,0,105,0,100,0,46,0,83,0,76,0,68,0,80,0,82,0,84,0,9,128,255,254,255,13,77,0,105,0,120,0,101,0,100,0,45,0,49,0,45,0,83,0,111,0,108,0,105,0,100,0,2,0,0,124,49,104,66,0,0,0,48,0,0,0,0,0,0,0,0,0,2,0,0,0,255,254,255,7,68,0,101,0,102,0,97,0,117,0,108,0,116,0,0,0,0,0,0,0,0,0,0,0,48,0,24,0,0,0,26,50,104,66,4,0,0,0,255,255,1,0,20,0,109,111,69,110,100,70,97,99,101,83,117,114,102,73,100,82,101,112,95,99,0,0,5,128,8,0,24,0,0,0,26,50,104,66,0,0,0,0,0,0,0,0,3,128,0,0,5,128,8,0,24,0,0,0,26,50,104,66,11,0,0,0,12,128,0,0,5,128,8,0,24,0,0,0,26,50,104,66,1,0,0,0,0,0,0,0,3,128,0,0,5,128,8,0,24,0,0,0,26,50,104,66,1,0,0,0,0,0,0,0,0,0,0,0,0,0";

            // Store constant in a collection
            pidCollection.Add( selection1 );

            // Pass this back
            return pidCollection;
        }

        #endregion

        #region Private Methods

        private static void SelectByPid( string pidName, ArrayList pidCollection, ref byte[] varEntity )
        {
            // Get the string from the collection
            var pidString = (string) pidCollection[0];

            // Parse the string into an array
            var pidVariant = pidString.Split( ',' );

            // Change the string array to a byte array
            var sizeArray = pidVariant.Length;
            var pid = new byte[sizeArray];
            for ( var i = 0; i < pidVariant.Length - 1; i++ )
            {
                pid[i] = Convert.ToByte( pidVariant[i] );
            }

            varEntity = pid;
        }

        #endregion
    }
}
