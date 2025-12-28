using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class PalindromeCheck
    {
        static void Main(String[] args)
        {
            // Calling Input Function to take Input
            string s = InputFun();

            // Calling Palindrome Function to check if given string is palindrome or not
            bool palindromeCheck = PalindromeFun(s);

            // Display Output
            Display(palindromeCheck, s);
        }
        static string InputFun()
        {
            Console.Write("Enter the string : ");
            return Console.ReadLine();
        }

        static bool PalindromeFun(String s)
        {
            s = s.Replace(" ", "").ToLower();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        static void Display(bool palindromeCheck, String s)
        {
            if (palindromeCheck) Console.WriteLine($"The String {s} is a palindrome.");
            else Console.WriteLine($"The String {s} is not a palindrome.");
        }
    }
}
