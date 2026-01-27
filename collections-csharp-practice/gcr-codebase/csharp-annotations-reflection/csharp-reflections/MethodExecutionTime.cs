using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class TestMethods
    {
        public void FastMethod()
        {
            for (int i = 0; i < 1000000; i++)
            {
            }
        }

        public void SlowMethod()
        {
            for (int i = 0; i < 5000000; i++)
            {
            }
        }
    }

    class MethodTimer
    {
        public static void Measure(object obj)
        {
            Type type = obj.GetType();

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();
                method.Invoke(obj, null);
                stopwatch.Stop();

                Console.WriteLine(
                    method.Name + " executed in " +
                    stopwatch.ElapsedMilliseconds + " ms");
            }
        }
    }

    internal class MethodExecutionTime
    {
        static void Main(string[] args)
        {
            TestMethods test = new TestMethods();
            MethodTimer.Measure(test);
        }
    }
}
