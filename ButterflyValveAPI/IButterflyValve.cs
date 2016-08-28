using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterflyValveAPI
{
    interface IButterflyValve
    {
        void CreatePart();
        void SetMaterial(string material);
        string[] GetMassProperties();
        void ChangeDimensions();
        void OpenPart(string place);
        void SavePart();
        void SavePart(string place);
    }
}
