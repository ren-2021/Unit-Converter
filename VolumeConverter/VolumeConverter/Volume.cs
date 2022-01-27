using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeConverter
{
    class Volume
    {
        public float CL { get; set; }
        public float Litre { get; set; }

        //A Return Method for Converting cl to litre
        public float ConvertToLitre()
        {
            Litre = CL / 100;
            return Litre;
        }

        //A Return Method for Converting litre to cl
        public float ConvertToCL()
        {
            CL = Litre * 100;
            return CL;
        }
    }
}
