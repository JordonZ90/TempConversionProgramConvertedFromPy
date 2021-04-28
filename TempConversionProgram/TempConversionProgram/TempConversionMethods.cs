using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConversionProgram
{
    public class TempConversionMethods
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            return fahrenheit;
        }
        public static double FahrenheitToKelvin(double fahrenheit)
        {
            double kelvin = (fahrenheit - 32) / 1.8 + 273.15;
            return kelvin;
        }
        public static double KelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = kelvin * 1.8 - 459.67;
            return fahrenheit;
        }
    }
}
