using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructor
{
    internal class EmployeeRecords
    {
        // Public member
        public int employeeID;

        // Protected member
        protected string department;

        // Private member
        private double salary;

        // Constructor
        public EmployeeRecords(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        // Method to modify salary
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

        // Method accessing protected member
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + employeeID);
            Console.WriteLine("Department  : " + department);
            Console.WriteLine("Salary      : " + salary);
        }

        static void Main()
        {
            EmployeeRecords e1 = new EmployeeRecords(154, "R&D", 55000);
            e1.DisplayEmployeeDetails();

            Console.WriteLine();
            e1.SetSalary(60000);
            Console.WriteLine("Updated Salary : " + e1.GetSalary());
        }
    }
}
