using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class UnitConverterYard
    {
        static class UnitConverter
        {
            public static double ConvertYardsToFeet(double yards) => 3 * yards;

            public static double ConvertFeetToYards(double feet) => 0.333333 * feet;

            public static double ConvertMetersToInches(double meters) => 39.3701 * meters;

            public static double ConvertInchesToMeters(double inches) => 0.0254 * inches;

            public static double ConvertInchesToCentimeters(double inches) => 2.54 * inches;
        }
        static void Main()
        {
            // Taking Input
            Console.WriteLine("Enter the distance details : ");
            Console.Write("Enter value in yards : ");
            double yards = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value in feet : ");
            double feet = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value in meters : ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value in inches : ");
            double inches = Convert.ToDouble(Console.ReadLine());

            // Call function/class to convert 

            double yards2feet = UnitConverter.ConvertYardsToFeet(yards);
            double feet2yards = UnitConverter.ConvertFeetToYards(feet);
            double meters2inches = UnitConverter.ConvertMetersToInches(meters);
            double inches2meters = UnitConverter.ConvertInchesToMeters(inches);
            double inches2cm = UnitConverter.ConvertInchesToCentimeters(inches);

            // Display Output
            Console.WriteLine($"Yards to feet : {yards2feet:F2}\n" +
                $"Feet to yards : {feet2yards:F2}\n" +
                $"Meters to inches : {meters2inches:F2}\n" +
                $"Inches to meters : {inches2meters:F2}\n" +
                $"Inches to centimeters : {inches2cm:F2}");
        }
    }
}
