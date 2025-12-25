using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class LeapYear
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the year you want to check : ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Call the function to check whether the year is leap or not.
            bool check = LeapCheck(year);

            // Display Output
            Console.WriteLine(check ? "The year is leap year." : "The year is not a leap year.");
        }

        static bool LeapCheck(int year)
        {
            if (year < 1582)
            {
                Console.Error.WriteLine("The year entered is invalid!");
                Environment.Exit(1);
                return false;
            }
            else if (year % 400 == 0) return true;
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            else return false;
        }
    }
}
