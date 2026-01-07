using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    // Employee Class Containing details regarding the employee
    internal class Employee
    {
        // Private fields of the employees 
        private int employeeId;
        private string employeeName;
        private double employeeSalary;
        private bool isPresent; // Checking if employee was present today or absent

        // Using getter and setter methods to get or set the values of the private variables
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

        public double EmployeeSalary
        {
            get { return employeeSalary; }
            set { employeeSalary = value; }
        }

        public bool IsPresent
        {
            get { return isPresent; }
            set { isPresent = value; }
        }

        // Writing ToString method to override the default one 
        public override string ToString()
        {
            return $"Name : {EmployeeName} || ID : {EmployeeId} || Salary : {EmployeeSalary} || Present : {IsPresent}";
        }

    }
}

