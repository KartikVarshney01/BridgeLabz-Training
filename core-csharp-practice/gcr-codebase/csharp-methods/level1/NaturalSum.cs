using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class NaturalSum
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling Function
            int sum = NSum(num);

            // Display Output
            Console.WriteLine($"The sum of {num} natural numbers is : {sum}");
        }

        static int NSum(int num)
        {
            int ans = 0;
            for (int i = 0; i <= num; i++)
            {
                ans += i;
            }
            return ans;
        }
    }
}
