using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    /// <summary>
    /// The program of Employee Management System helps us in understanding the use of encapsulation,
    /// interface and abstract fields 
    /// 
    /// version - 1.0
    /// </summary>
    internal class EmployeeManagementSystem
    {
        // Main Function or start of the program
        static void Main(string[] args)
        {
            // Creating an Employees Array to store employees data
            Employee[] employees = new Employee[2];

            Employee emp1 = new FullTimeEmployee(151, "Kartik", 45000);
            Employee emp2 = new PartTimeEmployee(254, "Harsh", 65, 600);

            ((IDepartment)emp1).AssignDepartment("R&D");
            ((IDepartment)emp2).AssignDepartment("Development");

            employees[0] = emp1;
            employees[1] = emp2;

            // Output Display
            foreach (Employee emp in employees)
            {
                emp.DisplayDetails();
                Console.WriteLine($"Department is : {((IDepartment)emp).GetDepartmentDetails()}");
                Console.WriteLine();
            }

        }
    }

    // Interface Department for Assign Department and Get Department Details
    interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();
    }

    // Abstract Class Employee
    abstract class Employee
    {
        // Secure fields for employeeID, employeeName and base Salary
        private int employeeId;
        private string employeeName;
        protected double baseSalary;

        // using Getter and setter to get values and protection
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        // Constructor
        public Employee(int employeeId, string employeeName, double baseSalary)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.baseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        // Function to display Employee Details
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee ID : {employeeId}");
            Console.WriteLine($"Employee Name : {employeeName}");
            Console.WriteLine($"Employee Salary : {CalculateSalary()}");
        }
    }

    // Derived Class of FullTimeEmployee 
    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        // Constructor
        public FullTimeEmployee(int empId, string empName, double salary)
            : base(empId, empName, salary)
        {

        }

        public override double CalculateSalary()
        {
            return baseSalary;
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }
    }

    // Derived Class of Part Time Employee
    class PartTimeEmployee : Employee, IDepartment
    {
        private int workHours;
        private double hourlyWage;
        private string department;

        // Constructor
        public PartTimeEmployee(int empId, string empName, int work, double rate)
            : base(empId, empName, 0)
        {
            workHours = work;
            hourlyWage = rate;
        }

        public override double CalculateSalary()
        {
            return hourlyWage * workHours;
        }

        public void AssignDepartment(string departmentName)
        {
            department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return department;
        }

    }
}
