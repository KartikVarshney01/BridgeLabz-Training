using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level1
{
    internal class DateFormatting
    {
        static void Main(String[] args)
        {
            // Taking todays date as input
            DateTime today = DateTime.Now;

            // Display Output
            Console.WriteLine("Current Date in Different Formats:\n");
            Console.WriteLine($"dd/MM/yyyy        : {today.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"yyyy-MM-dd        : {today.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"EEE, MMM dd, yyyy : {today.ToString("ddd, MMM dd, yyyy")}");
        }
    }
}
