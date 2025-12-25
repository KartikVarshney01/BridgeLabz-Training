using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class NaturalSum
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Checking if number is natural or not, of not then exiting the code.
            if (num <= 0)
            {
                Console.Error.WriteLine("The Number is not a natural number.");
                Environment.Exit(0);
            }

            // Calling recursive function to find sum of natural number.
            int sumrecursive = RecFunc(num);

            // Calling function to find sum of n natural numbers using formula
            int sumformula = FormulaFunc(num);

            // Displaying Output
            Console.WriteLine($"The Comparison between both is : Recursive Sum : {sumrecursive} , Formula Sum : {sumformula}");
        }

        static int RecFunc(int num)
        {
            if (num <= 0) return 0;
            return num + RecFunc(num - 1);
        }

        static int FormulaFunc(int num)
        {
            int sum = (num * (num + 1)) / 2;
            return sum;
        }
    }
}
