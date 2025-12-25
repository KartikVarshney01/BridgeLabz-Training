using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class NumberCheck3
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling function to find count, digits of number in array and reverse the array.
            int count = NumberChecker3.CountFun(num);
            int[] values = NumberChecker3.ValueFun(num, count);
            int[] reversevalue = NumberChecker3.ReverseFun(values);

            // Display output
            // Showing the values array
            Console.Write("Values : ");
            foreach (int x in values)
                Console.Write(x + " ");

            Console.Write("\nReverse Values : ");
            foreach (int x in reversevalue)
                Console.Write(x + " ");

            Console.WriteLine($"\nCheck if Arrays are Equal : {NumberChecker3.ArraysFun(values, reversevalue)}");

            Console.WriteLine($"Is Palindrome : {NumberChecker3.PalindromeFun(values)} ");

            Console.WriteLine($"Is Duck Number : {NumberChecker3.IsDuck(values)}");
        }
    }

    class NumberChecker3
    {
        public static int CountFun(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        public static int[] ValueFun(int num, int count)
        {
            int[] values = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                values[i] = num % 10;
                num /= 10;
            }
            return values;
        }

        public static int[] ReverseFun(int[] values)
        {
            int[] reversed = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                reversed[i] = values[values.Length - 1 - i];
            }
            return reversed;
        }

        public static bool ArraysFun(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }

        public static bool PalindromeFun(int[] values)
        {
            int[] reversed = ReverseFun(values);
            return ArraysFun(values, reversed);
        }

        public static bool IsDuck(int[] values)
        {
            foreach (int x in values)
            {
                if (x != 0)
                    return true;
            }
            return false;
        }
    }
}
