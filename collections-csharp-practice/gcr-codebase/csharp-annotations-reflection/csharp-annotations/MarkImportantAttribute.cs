using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class ImportantMethodAttribute : Attribute
    {
        public string Level;

        public ImportantMethodAttribute()
        {
            Level = "HIGH";
        }

        public ImportantMethodAttribute(string level)
        {
            Level = level;
        }
    }

    class Service
    {
        [ImportantMethod]
        public void StartService()
        {
            Console.WriteLine("Service started");
        }

        [ImportantMethod("LOW")]
        public void LogService()
        {
            Console.WriteLine("Service log saved");
        }

        public void HelperMethod()
        {
            Console.WriteLine("Helper method");
        }
    }
    internal class MarkImportantAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(Service);

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                object attribute = Attribute.GetCustomAttribute(method, typeof(ImportantMethodAttribute));

                if (attribute != null)
                {
                    ImportantMethodAttribute imp =
                        (ImportantMethodAttribute)attribute;

                    Console.WriteLine(
                        method.Name + " - Importance Level: " + imp.Level);
                }
            }
        }
    }
}
