using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class EmployeeSystem
    {
        // Static variable shared by all
        static string companyName = "FunTech";
        static int totalEmployee = 0;

        // readonly variable
        readonly int id;

        // Instance variable
        string empName;
        string designation;

        public EmployeeSystem(int id, string empName, string designation)
        {
            this.id = id;
            this.empName = empName;
            this.designation = designation;
            totalEmployee++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees : " + totalEmployee);
        }

        public static void DisplayEmployeeDetails(object obj)
        {
            if (obj is EmployeeSystem emp)
            {
                Console.WriteLine("Company Name : " + companyName);
                Console.WriteLine("Employee ID  : " + emp.id);
                Console.WriteLine("Name         : " + emp.empName);
                Console.WriteLine("Designation  : " + emp.designation);
            }
            else
            {
                Console.WriteLine("Invalid Employee Object");
            }
        }

        static void Main(String[] args)
        {
            EmployeeSystem emp1 = new EmployeeSystem(146, "Kartik", "Software Engineer");
            EmployeeSystem emp2 = new EmployeeSystem(22, "Karan", "Tester");

            EmployeeSystem.DisplayEmployeeDetails(emp1);
            Console.WriteLine();

            EmployeeSystem.DisplayEmployeeDetails(emp2);
            Console.WriteLine();

            EmployeeSystem.DisplayTotalEmployees();
        }
    }
}
