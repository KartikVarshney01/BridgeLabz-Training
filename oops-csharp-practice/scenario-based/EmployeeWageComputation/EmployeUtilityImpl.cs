using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    // Utility Class to store all the utility or functions that are in use. 
    // When adding a new UC we add its functionality in here
    internal class EmployeUtilityImpl : IEmployee
    {
        //private Employee _employee;
        // Initializing the random method for the 1st UC to get random input for present or absent
        private static Random random = new Random();

        // Writing the implementation of the Add Employee To add new employ or make a new employ
        public Employee AddEmployee()
        {
            // Creating a new Employ Object
            Employee employee = new Employee();

            // Taking Input for id,name and salary 
            Console.Write("Enter Employee Id: ");
            employee.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employee.EmployeeName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            employee.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

            // UC-1 random assigning present and absent using random function to 
            employee.IsPresent = random.Next(2) == 1;

            return employee;
        }

        // Display Employee Function to display employee according 
        public void DisplayEmployee(Employee employee)
        {
            Console.WriteLine(employee);
        }
        
        // UC-1 of assigning absent or present randomly
        public void CheckAttendance(Employee employee)
        {
            Console.WriteLine($"Employee Present Today : {employee.IsPresent}");
        }
    }
}
