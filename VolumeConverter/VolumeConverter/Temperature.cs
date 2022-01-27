using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeConverter
{
    class Temperature
    {
        public float Celcius { get; set; }
        public float Fahrenheit { get; set; }

        //A Return Method for Converting celcius to fahrenheit
        public float ConvertToFahrenheit()
        {
            Fahrenheit = (Celcius * 9 / 5) + 32;
            return Fahrenheit;
        }
        //A Return Method for Converting fahrenheit to celcius
        public float ConvertToCelcius()
        {
            Celcius = (Fahrenheit - 32) * 5 / 9;
            return Celcius;
        }
    }
}
