using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class LogExecutionTimeAttribute : Attribute
    {
    }

    class PerformanceTest
    {
        [LogExecutionTime]
        public void FastMethod()
        {
            for (int i = 0; i < 1000000; i++)
            { }
        }

        [LogExecutionTime]
        public void SlowMethod()
        {
            for (int i = 0; i < 5000000; i++)
            { }
        }
    }
    internal class MethodExecutionLogging
    {
        static void Main(string[] args)
        {
            PerformanceTest test = new PerformanceTest();
            Type type = typeof(PerformanceTest);

            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                if (Attribute.IsDefined(method, typeof(LogExecutionTimeAttribute)))
                {
                    Stopwatch stopwatch = new Stopwatch();

                    stopwatch.Start();
                    method.Invoke(test, null);
                    stopwatch.Stop();

                    Console.WriteLine(method.Name + " executed in " + stopwatch.ElapsedMilliseconds + " ms");
                }
            }
        }
    }
}
