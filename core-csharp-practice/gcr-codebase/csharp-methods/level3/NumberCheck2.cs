using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class NumberCheck2
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling function count to count digits and store them in array.
            int count = NumberChecker2.CountFun(num);
            int[] values = NumberChecker2.ValueFun(num, count);

            // Calling function to find sum, square sum and check if number is harshad or not.
            int sum = NumberChecker2.SumFun(values);
            int squareSum = NumberChecker2.SquareFun(values);
            bool isHarshad = NumberChecker2.HarshadFun(num, values);

            Console.WriteLine("Sum of Digits             : " + sum);
            Console.WriteLine("Sum of Squares of Digits  : " + squareSum);
            Console.WriteLine("Is Harshad Number         : " + isHarshad);

            int[,] frequency = NumberChecker2.DigitFrequency(values);

            Console.WriteLine("Digit Frequency");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine(frequency[i, 0] + "      " + frequency[i, 1]);
                }
            }
        }
    }
    class NumberChecker2
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

        public static int SumFun(int[] values)
        {
            int sum = 0;
            foreach (int d in values)
            {
                sum += d;
            }
            return sum;
        }

        public static int SquareFun(int[] values)
        {
            int sum = 0;
            foreach (int d in values)
            {
                sum += (int)Math.Pow(d, 2);
            }
            return sum;
        }

        public static bool HarshadFun(int num, int[] values)
        {
            int sum = SumFun(values);
            return num % sum == 0;
        }

        public static int[,] DigitFrequency(int[] values)
        {
            int[,] freq = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                freq[i, 0] = i;
                freq[i, 1] = 0;
            }

            foreach (int d in values)
            {
                freq[d, 1]++;
            }

            return freq;
        }
    }
}
