namespace ButterflyValveAPI
{
    internal interface IButterflyValve
    {
        void CreatePart();

        void SetMaterial( string material );

        string[] GetMassProperties();

        void ChangeDimensions();

        void OpenPart( string place );

        void SavePart();

        void SavePart( string place );
    }
}