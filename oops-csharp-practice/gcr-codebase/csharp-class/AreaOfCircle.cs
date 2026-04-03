using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.class_and_objects
{
    internal class AreaOfCircle
    {
        class Circle
        {
            double radius;

            // Use to set the radius value
            public void RadiusSet(double radius)
            {
                this.radius = radius;
            }
            // Finding the area of the circle
            public double AreaOfCircle()
            {
                return Math.PI * radius * radius;
            }

            // Finding Circumference of the circle
            public double CircumferenceOfCircle()
            {
                return 2 * Math.PI * radius;
            }

            // Display function to show details
            public void Display()
            {
                Console.WriteLine("Circle Details");
                Console.WriteLine($"Radius Of Circle : {radius}");
                Console.WriteLine($"Area Of Circle : {AreaOfCircle():F2}");
                Console.WriteLine($"Circumference Of Circle : {CircumferenceOfCircle():F2}");
            }
        }
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.RadiusSet(4);
            circle.Display();
        }
    }
}
