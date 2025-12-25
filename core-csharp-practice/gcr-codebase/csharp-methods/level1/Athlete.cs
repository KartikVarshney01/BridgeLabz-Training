using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class Athlete
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter the 3 sides of the triangle : ");
            Console.Write("Enter the 1st Side : ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd Side : ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd Side : ");
            int side3 = Convert.ToInt32(Console.ReadLine());

            // Computing perimeter
            int perimeter = side1 + side2 + side3;

            // Calling function Rounds to find number of rounds 
            int rounds = Rounds(perimeter);

            // Display Output
            Console.WriteLine($"The number of rounds needed to run is : {rounds}.");

        }
        static int Rounds(int perimeter)
        {
            // Converted 5km to 5000m
            int ans = 5000 / perimeter;
            return ans;
        }
    }
}
