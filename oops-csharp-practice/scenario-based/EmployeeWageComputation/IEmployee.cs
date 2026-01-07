using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    // Interface class IEmployee To Call The Functionalities 
    internal interface IEmployee
    {
        // Add Employee is used to create a new employee
        Employee AddEmployee();

        // Display is Used to display the Employ details
        void DisplayEmployee(Employee employee);

        // Check Attendance is used to check whether the current employee is present today or not.
        void CheckAttendance(Employee employee);

        // UC-2 CalculateDailyWage is used to calculate the daily wage depending on whether the employee is present or not.
        void CalculateDailyWage(Employee employee);
    }
}
