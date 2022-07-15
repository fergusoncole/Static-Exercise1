using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Exercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelsius(double x)
        {
            return (x - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double x)
        {
            return (x * 9) / 5 + 32;
        }
    }
}
