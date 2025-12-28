using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class BasicCalculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Basic Calculator");
            // Taking Input
            Console.Write("Enter first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation you want to perform : ");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Enter your choice : ");
            int op = Convert.ToInt32(Console.ReadLine());

            double ans = 0;
            bool choiceCheck = true;

            switch (op)
            {
                case 1:
                    ans = AddFun(num1, num2);
                    break;
                case 2:
                    ans = SubtractFun(num1, num2);
                    break;
                case 3:
                    ans = MultiplyFun(num1, num2);
                    break;
                case 4:
                    ans = DivideFun(num1, num2);
                    break;
                default:
                    choiceCheck = false;
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            // Display Output
            if (choiceCheck)
                Console.WriteLine($"The Result of your calculation is : {ans}");
        }

        static double AddFun(double num1, double num2)
        {
            return num1 + num2;
        }

        static double SubtractFun(double num1, double num2)
        {
            return num1 - num2;
        }

        static double MultiplyFun(double num1, double num2)
        {
            return num1 * num2;
        }

        static double DivideFun(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return 0;
            }
            return num1 / num2;
        }
    }
}
