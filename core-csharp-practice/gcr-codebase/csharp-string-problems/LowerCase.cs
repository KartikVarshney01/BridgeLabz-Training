using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class LowerCase
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the String : ");
            String s = Console.ReadLine();

            // Calling Function to convert string to lower case manually.
            String manualLower = LowerFun(s);

            // Using toLowerCase to convert 
            String lower = s.ToLower();

            // Display
            Console.WriteLine($"The Conversion to LowerCase using ASCII : {manualLower}");
            Console.WriteLine($"The Conversion to LowerCase using ToLower : {lower}");
            Console.WriteLine($"The Comparison between two is : {String.Equals(manualLower, lower)}");

        }

        static String LowerFun(String s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z') sb.Append((char)(s[i] + 32));
                else sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
