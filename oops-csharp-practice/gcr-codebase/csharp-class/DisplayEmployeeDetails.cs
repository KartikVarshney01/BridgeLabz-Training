using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.class_and_objects
{
    internal class DisplayEmployeeDetails
    {
        class Employee
        {
            // Creating variables
            string name;
            int id;
            double salary;

            // Function to Set Details in the class
            public void SetDetails(string empName, int empId, double empSalary)
            {
                name = empName;
                id = empId;
                salary = empSalary;
            }
            // Display Function to display details
            public void DisplayDetails()
            {
                Console.WriteLine("Employee Details");
                Console.WriteLine($"Employee Name : {this.name}");
                Console.WriteLine($"Employee ID : {this.id}");
                Console.WriteLine($"Employee Salary : {this.salary}");
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.SetDetails("Kartik", 1011, 30000);
            emp.DisplayDetails();
        }
    }
}
