using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class NumberCheck5
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Initializing factors fun to find the factors
            int[] factors = NumberChecker5.FactorsFun(num);

            // Display Output
            Console.Write("Factors:");
            foreach (int x in factors)
                Console.Write(x + " ");

            Console.WriteLine($"Greatest Factor : {NumberChecker5.GreatestFun(factors)}");
            Console.WriteLine($"Sum of Factors : {NumberChecker5.SumFun(factors)}");
            Console.WriteLine($"Product of Factors : {NumberChecker5.ProductFun(factors)}");
            Console.WriteLine($"Product of Cubes : {NumberChecker5.CubeProFun(factors)}");
            Console.WriteLine($"Is Perfect Number : {NumberChecker5.PerfectFun(num, factors)}");
            Console.WriteLine($"Is Abundant Number : {NumberChecker5.AbundantFun(num, factors)}");
            Console.WriteLine($"Is Deficient Number : {NumberChecker5.DeficientFun(num, factors)}");
            Console.WriteLine($"Is Strong Number : {NumberChecker5.StrongFun(num)}");
        }
    }

    class NumberChecker5
    {
        public static int[] FactorsFun(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            int[] factors = new int[count];
            int idx = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    factors[idx++] = i;
            }
            return factors;
        }

        public static int GreatestFun(int[] factors)
        {
            int max = factors[0];
            foreach (int x in factors)
            {
                if (x > max)
                    max = x;
            }
            return max;
        }
        public static int SumFun(int[] factors)
        {
            int sum = 0;
            foreach (int x in factors) sum += x;
            return sum;
        }
        public static long ProductFun(int[] factors)
        {
            long product = 1;
            foreach (int x in factors) product *= x;
            return product;
        }
        public static double CubeProFun(int[] factors)
        {
            double product = 1;
            foreach (int x in factors) product *= Math.Pow(x, 3);
            return product;
        }
        public static bool PerfectFun(int num, int[] factors)
        {
            int sum = 0;
            foreach (int x in factors)
            {
                if (x != num)
                    sum += x;
            }
            return sum == num;
        }
        public static bool AbundantFun(int num, int[] factors)
        {
            int sum = 0;
            foreach (int x in factors)
            {
                if (x != num)
                    sum += x;
            }
            return sum > num;
        }
        public static bool DeficientFun(int num, int[] factors)
        {
            int sum = 0;
            foreach (int x in factors)
            {
                if (x != num)
                    sum += x;
            }
            return sum < num;
        }
        public static bool StrongFun(int num)
        {
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {
                int rem = temp % 10;
                sum += FactorialFun(rem);
                temp /= 10;
            }

            return sum == num;
        }
        public static int FactorialFun(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
                fact *= i;
            return fact;
        }
    }
}
