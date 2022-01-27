using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeConverter
{
    class Area
    {
        private const double ha = 0.0001;
        private const double m2 = 10_000;

        public double Hectare { get; set; }
        public double MeterSquare { get; set; }

        //A Return Method for Converting ha to m2
        public double ConvertToMeterSquare()
        {
            MeterSquare = Hectare * m2;
            return MeterSquare;
        }

        //A Return Method for Converting m2 to ha
        public double ConvertToHectare()
        {
            Hectare = MeterSquare * ha;
            return Hectare;
        }
    }
}
