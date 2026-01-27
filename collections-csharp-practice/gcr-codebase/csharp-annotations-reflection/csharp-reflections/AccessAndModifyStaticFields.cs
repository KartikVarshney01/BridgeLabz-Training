using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Configuration
    {
        private static string API_KEY = "OLD_API_KEY";
    }
    internal class AccessAndModifyStaticFields
    {
        static void Main(string[] args)
        {
            Type type = typeof(Configuration);

            FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            field.SetValue(null, "NEW_API_KEY");

            string updatedKey = (string)field.GetValue(null);

            Console.WriteLine("Updated API_KEY: " + updatedKey);
        }
    }
}
