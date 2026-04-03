using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class DynamicObjectCreation
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);

            object obj = Activator.CreateInstance(type, new object[] { 1, "Kartik" });

            Student student = (Student)obj;

            student.Display();
        }
    }
}
