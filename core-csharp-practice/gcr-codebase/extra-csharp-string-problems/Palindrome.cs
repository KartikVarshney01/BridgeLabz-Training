using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string_problems
{
    internal class Palindrome
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the string : ");
            string s = Console.ReadLine().ToLower();

            //Using Two-Pointer Approach to find whether the string is palindrome or not.
            bool checkpalindrome = true;
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    checkpalindrome = false;
                    break;
                }
                left++;
                right--;
            }

            // Display Output
            Console.WriteLine(checkpalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
        }
    }
}
