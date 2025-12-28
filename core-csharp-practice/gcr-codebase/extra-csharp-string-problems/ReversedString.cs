using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class ReversedString
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine();

            // Initializing the ans string 
            StringBuilder reverse = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse.Append(s[i]);
            }

            // Display Output
            Console.WriteLine($"The reverse string is : {reverse.ToString()}");
        }
    }
}
