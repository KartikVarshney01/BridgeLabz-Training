using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class Compare
    {
        static void Main(String[] args)
        {
            // Taking String Input
            Console.WriteLine("Enter the Strings you want to compare : ");
            Console.Write("Enter the first string : ");
            String s1 = Console.ReadLine();
            Console.Write("Enter the second string : ");
            String s2 = Console.ReadLine();

            bool compareCharCheck = CompareString(s1, s2);

            bool compareCharEqual = String.Equals(s1, s2);

            // Display Output
            Console.WriteLine("The Comparison results are : ");
            Console.WriteLine($"The Comparison using CharAt is : {compareCharCheck}");
            Console.WriteLine($"The comparison using Equals method is : {compareCharEqual}");

        }
        static bool CompareString(String s1, String s2)
        {
            if (s1.Length != s2.Length) return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) return false;
            }
            return true;
        }
    }
}
