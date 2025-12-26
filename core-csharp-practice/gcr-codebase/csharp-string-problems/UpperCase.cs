using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class UpperCase
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the String : ");
            String s = Console.ReadLine();

            // Calling Function to convert string to upper casse manually.
            String manualUpper = UpperFun(s);

            // Using toUpperCase to convert 
            String upperCase = s.ToUpper();

            // Display
            Console.WriteLine($"The Conversion to uppercase using ASCII : {manualUpper}");
            Console.WriteLine($"The Conversion to uppercase using toUpper : {upperCase}");
            Console.WriteLine($"The Comparison between two is : {String.Equals(manualUpper, upperCase)}");

        }

        static String UpperFun(String s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z') sb.Append((char)(s[i] - 32));
                else sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
