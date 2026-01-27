using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class CacheResultAttribute : Attribute { }

    class Calculator
    {
        [CacheResult]
        public int SlowSquare(int number)
        {
            Console.WriteLine("Computing result...");
            System.Threading.Thread.Sleep(2000);
            return number * number;
        }
    }

    class CacheExecutor
    {
        private static Dictionary<string, object> cache = new Dictionary<string, object>();

        public static object Execute(object obj, string methodName, object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo method = type.GetMethod(methodName);

            if (Attribute.IsDefined(method, typeof(CacheResultAttribute)))
            {
                string key = methodName + "_" + parameters[0];

                if (cache.ContainsKey(key))
                {
                    Console.WriteLine("Returning cached result");
                    return cache[key];
                }

                object result = method.Invoke(obj, parameters);
                cache[key] = result;
                return result;
            }

            return method.Invoke(obj, parameters);
        }
    }
    internal class CustomCaching
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(CacheExecutor.Execute(calc, "SlowSquare", new object[] { 5 }));
            Console.WriteLine(CacheExecutor.Execute(calc, "SlowSquare", new object[] { 5 }));
            Console.WriteLine(CacheExecutor.Execute(calc, "SlowSquare", new object[] { 6 }));
        }
    }
}
