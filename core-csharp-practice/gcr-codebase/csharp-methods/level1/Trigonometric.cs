using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class Trigonometric
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the angle : ");
            double angle = Convert.ToDouble(Console.ReadLine());

            // Converting to radian
            double radian = angle * Math.PI / 180;

            // Calling Function
            double[] ans = CalculateTrigonometricFunctions(radian);

            // Display Output
            Console.WriteLine("The Trignometric Functions are : ");
            Console.WriteLine($"Sin({angle}) = {ans[0]:F2}");
            Console.WriteLine($"Cos({angle}) = {ans[1]:F2}");
            Console.WriteLine($"Tan({angle}) = {ans[2]:F2}");
        }
        static double[] CalculateTrigonometricFunctions(double angle)
        {
            double[] ans = new double[3];
            ans[0] = Math.Sin(angle);
            ans[1] = Math.Cos(angle);
            ans[2] = Math.Tan(angle);
            return ans;
        }

    }
}
