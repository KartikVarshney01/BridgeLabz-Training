using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class SpringSeason
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the Month : ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Day : ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Calling Function
            bool check = Check(month, day);

            // Display Output 
            Console.WriteLine(check ? "It's a Spring Season" : "It's not a Spring Season");
        }

        static bool Check(int month, int day)
        {
            return (month == 3 && day >= 20 && day < 32) ||
                (month == 4 && day > 0 && day < 31) ||
                (month == 5 && day > 0 && day < 32) ||
                (month == 6 && day > 0 && day <= 20);
        }
    }
}
