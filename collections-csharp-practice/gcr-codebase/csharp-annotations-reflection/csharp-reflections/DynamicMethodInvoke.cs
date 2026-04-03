using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    internal class DynamicMethodInvoke
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();
            Type type = typeof(MathOperations);

            Console.Write("Enter method name (Add, Subtract, Multiply): ");
            string methodName = Console.ReadLine();

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            MethodInfo method = type.GetMethod(methodName);

            if (method == null)
            {
                Console.WriteLine("Method not found");
                return;
            }

            object result = method.Invoke(math, new object[] { a, b });

            Console.WriteLine("Result: " + result);
        }
    }
}
