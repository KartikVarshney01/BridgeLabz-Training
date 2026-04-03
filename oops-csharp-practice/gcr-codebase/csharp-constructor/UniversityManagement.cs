using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class UniversityManagement
    {
        class Student
        {
            // Public member
            public int rollNumber;

            // Protected member
            protected string name;

            // Private member
            private double CGPA;

            // Parameterized Constructor
            public Student(int rollNumber, string name, double CGPA)
            {
                this.rollNumber = rollNumber;
                this.name = name;
                this.CGPA = CGPA;
            }

            // Public method to access CGPA
            public double GetCGPA()
            {
                return CGPA;
            }

            // Public method to modify CGPA
            public void SetCGPA(double CGPA)
            {
                this.CGPA = CGPA;
            }

            // Method accessing protected member inside the same class
            public void DisplayStudentDetails()
            {
                Console.WriteLine("Roll Number : " + rollNumber);
                Console.WriteLine("Name        : " + name);
                Console.WriteLine("CGPA        : " + CGPA);
            }

            static void Main()
            {
                Student s1 = new Student(15004, "Jon Doe", 8.5);

                s1.DisplayStudentDetails();

                Console.WriteLine();
                s1.SetCGPA(8.6);
                Console.WriteLine("Updated CGPA : " + s1.GetCGPA());
            }
        }
    }
}
