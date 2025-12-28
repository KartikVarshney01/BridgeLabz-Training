using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class GCDAndLCM
    {
        static void Main(String[] args)
        {
            // Taking Input
            int num1 = InputFun();
            int num2 = InputFun();

            //Caliing functions GCD and LCM to find gcd and lcm of two numbers
            int gcd = GCDFun(num1, num2);
            int lcm = LCMFun(num1, num2, gcd);

            // Display Output
            Display(num1, num2, gcd, lcm);
        }
        static int InputFun()
        {
            Console.Write("Enter the number : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GCDFun(int num1, int num2)
        {
            if (num2 > num1) return GCDFun(num2, num1);
            if (num2 == 0) return num1;
            return GCDFun(num2, num1 % num2);
        }

        static int LCMFun(int num1, int num2, int gcd)
        {
            return (num1 * num2) / gcd;
        }

        static void Display(int num1, int num2, int gcd, int lcm)
        {
            Console.WriteLine($"The gcd of {num1} and {num2} is {gcd}");
            Console.WriteLine($"The lcm of {num1} and {num2} is {lcm}");
        }
    }
}
