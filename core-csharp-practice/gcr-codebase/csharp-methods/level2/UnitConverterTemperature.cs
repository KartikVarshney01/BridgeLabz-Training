using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class UnitConverterTemperature
    {
        static class UnitConverter
        {
            public static double ConvertFahrenheitToCelsius(double fahrenheit)
                => (fahrenheit - 32) * 5 / 9;

            public static double ConvertCelsiusToFahrenheit(double celsius)
                => (celsius * 9 / 5) + 32;

            public static double ConvertPoundsToKilograms(double pounds)
                => pounds * 0.453592;

            public static double ConvertKilogramsToPounds(double kilograms)
                => kilograms * 2.20462;

            public static double ConvertGallonsToLiters(double gallons)
                => gallons * 3.78541;

            public static double ConvertLitersToGallons(double liters)
                => liters * 0.264172;
        }
        static void Main()
        {
            // Taking Input
            Console.WriteLine("Enter data for conversion : ");
            Console.Write("Enter temperature in Fahrenheit : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter weight in pounds : ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter weight in kilograms : ");
            double kilograms = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter volume in gallons : ");
            double gallons = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter volume in liters : ");
            double liters = Convert.ToDouble(Console.ReadLine());

            // Display Output and calling class

            Console.WriteLine($"Fahrenheit to Celsius : {UnitConverter.ConvertFahrenheitToCelsius(fahrenheit):F2}");
            Console.WriteLine($"Celsius to Fahrenheit : {UnitConverter.ConvertCelsiusToFahrenheit(celsius):F2}");
            Console.WriteLine($"Pounds to Kilograms : {UnitConverter.ConvertPoundsToKilograms(pounds):F2}");
            Console.WriteLine($"Kilograms to Pounds : {UnitConverter.ConvertKilogramsToPounds(kilograms):F2}");
            Console.WriteLine($"Gallons to Liters : {UnitConverter.ConvertGallonsToLiters(gallons):F2}");
            Console.WriteLine($"Liters to Gallons : {UnitConverter.ConvertLitersToGallons(liters):F2}");
        }
    }
}
