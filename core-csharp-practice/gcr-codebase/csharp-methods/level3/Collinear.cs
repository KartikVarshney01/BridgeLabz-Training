using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Collinear
    {
        static void Main(String[] args)
        {
            // Initializing Input variables
            double x1 = 2, y1 = 4;
            double x2 = 4, y2 = 6;
            double x3 = 6, y3 = 8;

            Console.WriteLine("Given Points are : ");
            Console.WriteLine($"A({x1},{y1}), B({x2},{y2}), C({x3},{y3})");

            bool slope = SlopeFun(x1, y1, x2, y2, x3, y3);

            bool area = AreaFun(x1, y1, x2, y2, x3, y3);

            // Display Output
            Console.WriteLine($"Using Slope Formula : {slope}");
            Console.WriteLine($"Using Area Formula  : {area}");
        }
        static bool SlopeFun(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double AB = (y2 - y1) / (x2 - x1);
            double BC = (y3 - y2) / (x3 - x2);
            double AC = (y3 - y1) / (x3 - x1);

            return AB == BC && BC == AC;
        }

        static bool AreaFun(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            return area == 0;
        }
    }
}
