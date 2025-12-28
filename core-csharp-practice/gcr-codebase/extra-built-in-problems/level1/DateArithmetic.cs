using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level1
{
    internal class DateArithmetic
    {
        static void Main(String[] args)
        {
            // Taking the input date 
            Console.Write("Enter a date (dd-mm-yyyy) : ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            // Adding 7 days
            DateTime resultDate = date.AddDays(7);

            resultDate = resultDate.AddMonths(1);

            resultDate = resultDate.AddYears(2);

            resultDate = resultDate.AddDays(-21);

            Console.WriteLine("Final Date after operations is : " + resultDate.ToShortDateString());
        }
    }
}
