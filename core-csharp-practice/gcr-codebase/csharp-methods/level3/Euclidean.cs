using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Euclidean
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter the distance co-ordinates : ");
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calling fun to find distance and line
            double distance = DistanceFun(x1, y1, x2, y2);
            double[] line = LineEquationFun(x1, y1, x2, y2);

            // Display Output
            Console.WriteLine("The Results are : ");
            Console.WriteLine($"Euclidean Distance = {distance:F2}");
            Console.WriteLine($"Equation of Line : m = {line[0]} , b = {line[1]}");
        }
        static double DistanceFun(double x1, double y1, double x2, double y2)
        {
            double dx = Math.Pow(x2 - x1, 2);
            double dy = Math.Pow(y2 - y1, 2);
            return Math.Sqrt(dx + dy);
        }
        static double[] LineEquationFun(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - (m * x1);

            return new double[] { m, b };
        }
    }
}
