using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class Factors
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling function to find factors
            int[] fact = FactorsFun(num);

            // calling the function to find the sum and the square of factors sum
            int[] ans = FactorsSum(fact);

            // calling function to find the product of factors
            long products = FactorsProduct(fact);

            // Display Output
            Console.WriteLine($"The Sum of Factors : {ans[0]}, Sum of Square of factors : {ans[1]}, And the Product of Factors : {products}");

        }

        static int[] FactorsFun(int num)
        {
            int[] fact = new int[50];
            int idx = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    fact[idx++] = i;
                }
            }
            return fact;
        }

        static int[] FactorsSum(int[] fact)
        {
            int[] ans = new int[2];
            int sum = 0; //Sum of factors
            int squareSum = 0; //Sum of factors square
            foreach (int i in fact)
            {
                if (i == 0) break;
                sum += i;
                squareSum += (int)Math.Pow(i, 2);
            }
            ans[0] = sum;
            ans[1] = squareSum;

            return ans;
        }

        static long FactorsProduct(int[] fact)
        {
            long product = 1; // Product of factors
            foreach (int i in fact)
            {
                if (i == 0) break;
                product *= i;
            }
            return product;
        }
    }
}
