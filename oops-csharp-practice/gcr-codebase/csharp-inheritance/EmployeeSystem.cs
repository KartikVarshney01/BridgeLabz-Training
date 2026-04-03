using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class EmployeeSystem
    {
        static void Main()
        {
            Employee e1 = new Manager("Kartik", 156, 85000, 10);
            Employee e2 = new Developer("Harsh", 162, 60000, "C#");
            Employee e3 = new Intern("Rahul", 185, 15000, "6 Months");

            e1.DisplayDetails();
            Console.WriteLine();

            e2.DisplayDetails();
            Console.WriteLine();

            e3.DisplayDetails();
        }
    }
    class Employee
    {
        public string Name;
        public int Id;
        public double Salary;

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name   : " + Name);
            Console.WriteLine("ID     : " + Id);
            Console.WriteLine("Salary : " + Salary);
        }
    }

    class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size : " + TeamSize);
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public Developer(string name, int id, double salary, string language)
            : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Language : " + ProgrammingLanguage);
        }
    }

    class Intern : Employee
    {
        public string InternshipDuration;

        public Intern(string name, int id, double salary, string duration)
            : base(name, id, salary)
        {
            InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Duration : " + InternshipDuration);
        }
    }
}


