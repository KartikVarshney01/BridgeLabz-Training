using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class TemperatureConverter
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter temperature in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = FahrenheitFun(celsius);
                Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = CelsiusFun(fahrenheit);
                Console.WriteLine($"{fahrenheit}°F = {celsius:F2}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            }
        }
        static double FahrenheitFun(double c)
        {
            return (c * 9 / 5) + 32;
        }

        static double CelsiusFun(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
