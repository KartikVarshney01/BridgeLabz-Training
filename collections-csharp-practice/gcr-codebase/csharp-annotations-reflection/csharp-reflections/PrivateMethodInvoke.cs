using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Calculator
    {
        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    internal class PrivateMethodInvoke
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Type type = typeof(Calculator);

            MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            object result = method.Invoke(calculator, new object[] { 5, 4 });

            Console.WriteLine("Result: " + result);
        }
    }
}
