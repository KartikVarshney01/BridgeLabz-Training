using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Student
    {
        public int Id;
        private string Name;

        public Student() { }

        public Student(int id)
        {
            this.Id = id;
        }

        public void ShowDetails() { }

        private void CalculateResult() { }
    }

    internal class ClassInformation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter class name: ");
            string className = Console.ReadLine();

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes()
                .FirstOrDefault(t => t.Name.Equals(className, StringComparison.OrdinalIgnoreCase));

            if (type == null)
            {
                Console.WriteLine("Class not found");
                return;
            }

            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Instance))
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.WriteLine(ctor.Name);
            }
        }
    }
}

