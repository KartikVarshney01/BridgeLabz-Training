using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class NumberCheck
    {
        static void Main()
        {
            // Taking Input
            Console.WriteLine("Enter 5 values for checking : ");

            // Creating array to store 5 values
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display Output
            Console.WriteLine("The number check for positive(even and odd) and negative.");
            CheckPositivity(arr);
            // Checking 1st and 5th element for eqaul,greater or lesser to.
            Console.Write($"The COmparison of First and Last Element is : ");
            Compare(arr);
        }

        static void CheckPositivity(int[] arr)
        {

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    bool check = CheckEvenOdd(i);
                    Console.WriteLine(check ? $"{i} is : Positive and Even" : $"{i} Positive and Odd");
                }
                else if (i < 0) Console.WriteLine($"{i} : Number is Negative");
                else Console.WriteLine($"{i} : Number is Zero");
            }
        }

        static bool CheckEvenOdd(int n)
        {
            return (n % 2 == 0);
        }

        static void Compare(int[] arr)
        {
            if (arr[0] == arr[4]) Console.WriteLine("0");
            Console.WriteLine(arr[0] > arr[4] ? "1" : "-1");
        }
    }
}
