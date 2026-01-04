using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class UniversitySystem
    {
        public static string UniversityName = "Indian University";
        private static int totalStudents = 0;

        public readonly int RollNumber;
        public string Name;
        public string Grade;

        public UniversitySystem(int RollNumber, string Name, string Grade)
        {
            this.RollNumber = RollNumber;
            this.Name = Name;
            this.Grade = Grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine("Total Students : " + totalStudents);
        }

        public static void DisplayStudentDetails(object obj)
        {
            if (obj is UniversitySystem s)
            {
                Console.WriteLine("University : " + UniversityName);
                Console.WriteLine("Roll No    : " + s.RollNumber);
                Console.WriteLine("Name       : " + s.Name);
                Console.WriteLine("Grade      : " + s.Grade);
            }
            else
            {
                Console.WriteLine("Invalid Student Object");
            }
        }

        static void Main(String[] args)
        {
            UniversitySystem s1 = new UniversitySystem(1, "Amit", "A");
            UniversitySystem s2 = new UniversitySystem(2, "Neha", "B");

            UniversitySystem.DisplayStudentDetails(s1);
            UniversitySystem.DisplayStudentDetails(s2);
            UniversitySystem.DisplayTotalStudents();
        }
    }
}
