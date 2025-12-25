using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class NumberCheck
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = NumberChecker.CountFun(num);
            int[] digits = NumberChecker.DigitsFun(num, count);

            Console.WriteLine($"Total Digits : {count}");
            Console.WriteLine($"Is Duck Number      : {NumberChecker.IsDuck(digits)}");
            Console.WriteLine($"Is Armstrong Number : {NumberChecker.ArmstrongCheck(digits, num)}");

            NumberChecker.LargestAndSecondLargest(digits);
            NumberChecker.SmallestAndSecondSmallest(digits);
        }
    }
    class NumberChecker
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

        public static int[] DigitsFun(int num, int count)
        {
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = num % 10;
                num /= 10;
            }
            return digits;
        }

        public static bool IsDuck(int[] digits)
        {
            foreach (int d in digits)
            {
                if (d != 0)
                    return true;
            }
            return false;
        }

        public static bool ArmstrongCheck(int[] digits, int num)
        {
            int power = digits.Length;
            int sum = 0;

            foreach (int d in digits)
            {
                sum += (int)Math.Pow(d, power);
            }

            return sum == num;
        }

        public static void LargestAndSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            foreach (int x in digits)
            {
                if (x > largest)
                {
                    secondLargest = largest;
                    largest = x;
                }
                else if (x > secondLargest && x != largest)
                {
                    secondLargest = x;
                }
            }

            Console.WriteLine($"Largest Digit        : {largest}");
            Console.WriteLine($"Second Largest Digit : {secondLargest}");
        }

        public static void SmallestAndSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            foreach (int x in digits)
            {
                if (x < smallest)
                {
                    secondSmallest = smallest;
                    smallest = x;
                }
                else if (x < secondSmallest && x != smallest)
                {
                    secondSmallest = x;
                }
            }

            Console.WriteLine($"Smallest Digit        : {smallest}");
            Console.WriteLine($"Second Smallest Digit : {secondSmallest}");
        }
    }
}


