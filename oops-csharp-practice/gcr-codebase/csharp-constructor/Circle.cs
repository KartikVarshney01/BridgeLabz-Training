using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class Circle
    {
        double radius;

        // Default Constructor
        public Circle()
        {
            radius = 4.0;
        }

        // User-Defined Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public void Display()
        {
            Console.WriteLine($"Circle Radius is : {radius}");
        }
        static void Main(String[] args)
        {
            Circle c1 = new Circle();
            c1.Display();

            Circle c2 = new Circle(5);
            c2.Display();
        }
    }
}
