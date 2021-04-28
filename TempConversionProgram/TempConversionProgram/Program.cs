using System;

namespace TempConversionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            ConvertTemperatures();
        }
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("3. Fahrenheit to Kelvin");
            Console.WriteLine("4. Kelvin to Fahrenheit");
            Console.WriteLine("");
        }
        public static void ConvertTemperatures()
        {
            string again = "y";

            while (again == "y".ToLower())
            {
                Console.WriteLine("Enter a menu option ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Enter temperature in Fahrenheit ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double celsius = TempConversionMethods.FahrenheitToCelsius(fahrenheit);
                    celsius = Math.Round(celsius, 2);
                    Console.WriteLine($"Degrees {celsius} Celsius");
                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter temperature in Celsius ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = TempConversionMethods.CelsiusToFahrenheit(celsius);
                    fahrenheit = Math.Round(fahrenheit, 2);
                    Console.WriteLine($"Degrees {fahrenheit} Fahrenheit");
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter temperature in Fahrenheit ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    double kelvin = TempConversionMethods.FahrenheitToKelvin(fahrenheit);
                    kelvin = Math.Round(kelvin, 2);
                    Console.WriteLine($"Degrees {kelvin} kelvin");
                }
                else if (option == 4)
                {
                    Console.WriteLine("Enter degrees in Kelvin ");
                    double kelvin = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = TempConversionMethods.KelvinToFahrenheit(kelvin);
                    fahrenheit = Math.Round(fahrenheit, 2);
                    Console.WriteLine($"Degrees {fahrenheit} Fahrenheit");
                }
                else
                {
                    Console.WriteLine("You must enter a valid menu number");
                }

                Console.WriteLine("Convert another measurement? (y|n)");
                again = Console.ReadLine();
                if (again == "y")
                {
                    Menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}
