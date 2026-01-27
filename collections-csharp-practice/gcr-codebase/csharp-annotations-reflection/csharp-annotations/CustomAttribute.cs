using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    class TaskInfoAttribute : Attribute
    {
        public int Priority;
        public string AssignedTo;

        public TaskInfoAttribute(int priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager
    {
        [TaskInfo(1, "Kartik")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }
    internal class CustomAttribute
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();

            Type type = typeof(TaskManager);
            MethodInfo method = type.GetMethod("CompleteTask");

            TaskInfoAttribute attribute =
                (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

            Console.WriteLine("Priority: " + attribute.Priority);
            Console.WriteLine("Assigned To: " + attribute.AssignedTo);
        }
    }
}
