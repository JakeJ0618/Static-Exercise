using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = (fTemp - 32) * (5.0 / 9.0);
            return celTemp;
        }
        public static double CelsiusToFahrenheit(double celTemp)
        {
            return celTemp * (9.0 / 5.0) + 32;
        }
    }
   
}
