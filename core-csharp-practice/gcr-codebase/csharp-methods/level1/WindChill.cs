using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class WindChill
    {
        static void Main(String[] args)
        {
            // Taking Input 
            Console.WriteLine("Enter the temperature and wind speed : ");
            Console.Write("Enter the temperature : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the temperature : ");
            double windspeed = Convert.ToDouble(Console.ReadLine());

            // Calling Function and Calculating windchill
            double windchill = CalculateWindChill(temperature, windspeed);

            // Display Output
            Console.WriteLine($"The windchill generated for temperature {temperature} and wind Speed {windspeed} is {windchill:F2}. ");
        }
        static double CalculateWindChill(double temperature, double windSpeed)
        {
            double windchill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
            return windchill;
        }

    }
}
