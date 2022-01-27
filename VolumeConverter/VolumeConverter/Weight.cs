using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeConverter
{
    class Weight
    {
        //Fields
        private const double oz = 35.2739619;
        private const double kg = 0.02834952;

        //Properties
        public double Ounce { get; set; }
        public double Kilogram { get; set; }

        //A Return Method for Converting kg to oz
        public double ConvertToOunce()
        {
            Ounce = Kilogram * oz;
            return Ounce;
        }

        //A Return method for converting ounce to kilogram 
        public double ConvertToKilogram()
        {
            Kilogram = Ounce * kg;
            return Kilogram;
        }
    }
}
