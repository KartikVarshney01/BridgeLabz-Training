using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class TodoAttribute : Attribute
    {
        public string Task;
        public string AssignedTo;
        public string Priority;

        public TodoAttribute(string task, string assignedTo)
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = "MEDIUM";
        }

        public TodoAttribute(string task, string assignedTo, string priority)
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    class Project
    {
        [Todo("Implement login feature", "Amit")]
        public void Login()
        {
        }

        [Todo("Add validation", "Neha", "HIGH")]
        public void Validate()
        {
        }

        [Todo("Optimize performance", "Rahul")]
        public void Optimize()
        {
        }
    }
    internal class ToDoAttribute
    {
        static void Main(string[] args)
        {
            Type type = typeof(Project);

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);

                foreach (TodoAttribute todo in attributes)
                {
                    Console.WriteLine("Method: " + method.Name);
                    Console.WriteLine("Task: " + todo.Task);
                    Console.WriteLine("Assigned To: " + todo.AssignedTo);
                    Console.WriteLine("Priority: " + todo.Priority);
                    Console.WriteLine();
                }
            }
        }
    }
}
