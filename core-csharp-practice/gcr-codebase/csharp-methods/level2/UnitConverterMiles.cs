using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class UnitConverterMiles
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter the distance : ");
            Console.Write("Enter the distance in km : ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance in miles : ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance in meters : ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance in feet : ");
            double feet = Convert.ToDouble(Console.ReadLine());

            // calling function
            double km2miles = ConvertKmToMiles(km);
            double miles2km = ConvertMilesToKm(miles);
            double meter2feet = ConvertMeterToFeet(meters);
            double feet2meters = ConvertFeetToMeter(feet);

            // Output 
            Console.WriteLine($"The km to miles is : {km2miles:F2}\n" +
                $"The miles to km is : {miles2km:F2}\n" +
                $"The meters to feet is : {meter2feet:F2}\n" +
                $"The feet to meters is : {feet2meters:F2}");
        }

        static double ConvertKmToMiles(double km)
        {
            double kmtomiles = km * 0.621371;
            return kmtomiles;
        }

        static double ConvertMilesToKm(double miles)
        {
            double milestokm = miles * 1.60934;
            return milestokm;
        }

        static double ConvertMeterToFeet(double meter)
        {
            double metertofeet = meter * 3.28084;
            return metertofeet;
        }

        static double ConvertFeetToMeter(double feet)
        {
            double feettometer = feet * 0.3048;
            return feettometer;
        }
    }
}
