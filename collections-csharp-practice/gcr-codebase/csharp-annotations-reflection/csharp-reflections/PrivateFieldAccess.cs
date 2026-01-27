using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflections
{
    class Person
    {
        private int age;

        public Person(int age)
        {
            this.age = age;
        }
    }
    internal class PrivateFieldAccess
    {
        static void Main(string[] args)
        {
            Person person = new Person(20);

            Type type = typeof(Person);

            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            field.SetValue(person, 30);

            int updatedAge = (int)field.GetValue(person);

            Console.WriteLine("Updated Age: " + updatedAge);
        }
    }
}
