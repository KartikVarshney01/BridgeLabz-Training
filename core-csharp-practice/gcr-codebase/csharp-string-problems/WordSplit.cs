using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string_problems
{
    internal class WordSplit
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the message : ");
            String text = Console.ReadLine();

            // Calling function to split the text and getting length;
            String[,] ans = SplitAndLength(text);

            // Display 
            for (int i = 0; i < ans.GetLength(0); i++)
            {
                Console.WriteLine($"{ans[i, 0]} : {ans[i, 1]}");
            }
        }

        static String[,] SplitAndLength(String text)
        {
            int count = 0;
            foreach (char ch in text) if (ch == ' ') count++;

            string[,] ans = new string[count + 1, 2];

            int i = 0, j = 0;
            int idx = 0;

            while (j < text.Length)
            {
                if (text[j] == ' ')
                {
                    ans[idx, 0] = text.Substring(i, j - i);
                    ans[idx, 1] = LengthFun(ans[idx, 0]).ToString();
                    i = ++j;
                    idx++;
                }
                j++;
            }
            ans[idx, 0] = text.Substring(i);
            ans[idx, 1] = LengthFun(ans[idx, 0]).ToString();

            return ans;

        }
        static int LengthFun(string s)
        {
            int len = 0;
            foreach (char ch in s) len++;
            return len;
        }
    }
}
