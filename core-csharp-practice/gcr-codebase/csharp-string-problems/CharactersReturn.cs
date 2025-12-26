using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class CharactersReturn
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the String : ");
            string s = Console.ReadLine();

            // calling function to find characters using charAt.
            char[] manualChars = ManualChars(s);

            // finding char using tochararray
            char[] charMethod = s.ToCharArray();

            bool check = Compare(manualChars, charMethod);

            // Display Output
            Console.WriteLine("The characters array using charAT : ");
            Display(manualChars);

            Console.WriteLine("The characters array using built-in method : ");
            Display(charMethod);

            Console.WriteLine($"Their Comparison is : {check}");

        }

        static char[] ManualChars(string s)
        {
            char[] ans = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                ans[i] = s[i];
            }
            return ans;
        }

        static char[] AutoChar(string s)
        {
            char[] ans = new char[s.Length];
            int idx = 0;
            foreach (char c in s)
            {
                ans[idx++] = c;
            }
            return ans;
        }

        static void Display(char[] ans)
        {
            for (int i = 0; i < ans.Length; i++)
            {
                Console.Write(ans[i] + " ");
            }
            Console.WriteLine();
        }

        static bool Compare(char[] a, char[] b)
        {
            if (a.Length != b.Length) return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
    }
}
