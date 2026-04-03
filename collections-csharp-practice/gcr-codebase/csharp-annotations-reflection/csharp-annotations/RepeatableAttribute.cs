using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class BugReportAttribute : Attribute
    {
        public string Description;

        public BugReportAttribute(string description)
        {
            Description = description;
        }
    }

    class Software
    {
        [BugReport("Null reference occurs sometimes")]
        [BugReport("Performance issue when input is large")]
        public void Run()
        {
            Console.WriteLine("Software is running");
        }
    }

    internal class RepeatableAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(Software);
            MethodInfo method = type.GetMethod("Run");

            object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);

            foreach (BugReportAttribute bug in attributes)
            {
                Console.WriteLine("Bug: " + bug.Description);
            }
        }
    }
}
