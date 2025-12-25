using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class QuadraticRoot
    {
        static void Main(String[] args)
        {
            // Taking Input of a,b and c
            Console.Write("Enter value of a : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calling Function Find Roots
            double[] roots = RootsFun(a, b, c);

            // Display Output
            Console.WriteLine("The roots if possible for equation : ");
            if (roots.Length == 0)
            {
                Console.WriteLine("No real roots (Delta is negative)");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"Only one root : {roots[0]:F2}");
            }
            else
            {
                Console.WriteLine($"Root 1 : {roots[0]:F2}");
                Console.WriteLine($"Root 2 : {roots[1]:F2}");
            }
        }

        static double[] RootsFun(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                return new double[0];
            }
        }
    }
}
