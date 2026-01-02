using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class Person
    {
        string name;
        int age;

        // Parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy constructor
        public Person(Person p)
        {
            this.name = p.name;
            this.age = p.age;
        }

        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }

        static void Main()
        {
            Person p1 = new Person("Kartik", 23);
            Person p2 = new Person(p1);   // Copying p1 into p2

            Console.WriteLine("Original Person");
            p1.Display();

            Console.WriteLine();

            Console.WriteLine("Copied Person");
            p2.Display();
        }
    }
}
