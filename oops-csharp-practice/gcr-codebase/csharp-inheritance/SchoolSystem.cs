using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class SchoolSystem
    {
        static void Main(String[] args)
        {
            Teacher t = new Teacher("Anita", 35, "Mathematics");
            Student s = new Student("Ravi", 16, "10th");
            Staff st = new Staff("Mahesh", 42, "Administration");

            t.DisplayRole();
            Console.WriteLine();

            s.DisplayRole();
            Console.WriteLine();

            st.DisplayRole();
        }
    }
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role    : Teacher");
            Console.WriteLine("Name    : " + Name);
            Console.WriteLine("Age     : " + Age);
            Console.WriteLine("Subject : " + Subject);
        }
    }

    class Student : Person
    {
        public string Grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role  : Student");
            Console.WriteLine("Name  : " + Name);
            Console.WriteLine("Age   : " + Age);
            Console.WriteLine("Grade : " + Grade);
        }
    }

    class Staff : Person
    {
        public string Department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Role       : Staff");
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Age        : " + Age);
            Console.WriteLine("Department : " + Department);
        }
    }
}
