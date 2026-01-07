using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

        // Creating Daily Wage Rate and Hours for UC-2
        private int perHourWage = 20;
        private int fullDayHours = 8;

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

            Console.Write("Enter Whether Employee is Full Time Or Part Time (part/full): ");
            string partOrFull = Console.ReadLine();
            employee.IsFullOrPart = partOrFull.ToLower() == "full";

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

        // UC-2 works on calculating daily wages based on whether a employee is present or not.
        public void CalculateDailyWage(Employee employee)
        {
            if (employee.IsPresent)
            {
                int dailyWage = perHourWage * fullDayHours;
                Console.WriteLine($"The Daily wage of employee is : {dailyWage}");
            }
            else
            {
                Console.WriteLine("Employee is absent today. Today's Wage is 0");

            }
        }

        // UC-3 works on calculating daily wages for a part time employee
        public void CalculatePartTimeWage(Employee employee)
        {
            int partTimeHours = 8;
            // Checking if the employee is present and part time.
            if (employee.IsPresent && !employee.IsFullOrPart)
            {
                int partDailyWage = partTimeHours * perHourWage;
                Console.WriteLine($"The Part Time Employee Daily Wage : {partDailyWage}");
            }
            else
            {
                Console.WriteLine("Employee Is Not a Part Time Employee Or is Absent Today");
            }
        }
    }
}
