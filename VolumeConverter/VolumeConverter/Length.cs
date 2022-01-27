using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeConverter
{
    class Length
    {
        private const double mi = 0.6214;
        private const double km = 1.609269391696169939;
        public double Kilometer { get; set; }
        public double Miles { get; set; }

        //A Return Method for Converting km to mile
        public double ConvertToMile()
        {
            Miles = Kilometer * mi;
            return Miles;
        }

        //A Return Method for Converting mile to km
        public double ConvertToKM()
        {
            Kilometer = Miles * km;
            return Kilometer;
        }
    }
}
