using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level1
{
    internal class DateCompare
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter first date (dd-mm-yyyy) : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter second date (dd-mm-yyyy) : ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            // Comparing dates using Compare function
            int result = DateTime.Compare(date1, date2);

            // Display Output
            if (result < 0)
                Console.WriteLine("First date is Before the second date");
            else if (result > 0)
                Console.WriteLine("First date is After the second date");
            else
                Console.WriteLine("Both dates are the Same");
        }
    }
}
