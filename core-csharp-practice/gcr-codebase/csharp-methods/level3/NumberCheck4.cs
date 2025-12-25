using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class NumberCheck4
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Display Output
            Console.WriteLine($"The Check of prime, Neon, Spy, Automorphic, and Buzz is : ");
            Console.WriteLine($"Is Prime Number :  {NumberChecker4.PrimeFun(num)}");
            Console.WriteLine($"Is Neon Number :  {NumberChecker4.NeonFun(num)}");
            Console.WriteLine($"Is Spy Number : {NumberChecker4.SpyFun(num)}");
            Console.WriteLine($"Is Automorphic Number: {NumberChecker4.AutomorphicFun(num)}");
            Console.WriteLine($"Is Buzz Number : {NumberChecker4.BuzzFun(num)}");
        }
    }

    class NumberChecker4
    {
        public static bool PrimeFun(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public static bool NeonFun(int num)
        {
            int square = num * num;
            int sum = 0;

            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }

            return sum == num;
        }

        public static bool SpyFun(int num)
        {
            int sum = 0;
            int product = 1;

            while (num > 0)
            {
                int rem = num % 10;
                sum += rem;
                product *= rem;
                num /= 10;
            }

            return sum == product;
        }

        public static bool AutomorphicFun(int num)
        {
            int square = num * num;
            int temp = num;

            while (temp > 0)
            {
                if (square % 10 != temp % 10)
                    return false;

                square /= 10;
                temp /= 10;
            }
            return true;
        }

        public static bool BuzzFun(int num)
        {
            return (num % 7 == 0) || (num % 10 == 7);
        }
    }
}
