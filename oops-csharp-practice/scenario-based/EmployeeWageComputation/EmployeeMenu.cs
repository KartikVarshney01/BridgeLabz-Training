using BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    // Employee Menu Class That contains the menu of our program and is used to call the functionality from the
    // employeeutilityimpl.
    internal class EmployeeMenu
    {
        // Creating reference of the interface and employee class
        private IEmployee utilityCall;
        private Employee currentEmployee;

        // EmployeeChoice function to show employee choices
        public void EmployeeChoice()
        {
            // Creating the object for the Employee Utility Impl
            utilityCall = new EmployeUtilityImpl();

            while (true)
            {

                Console.WriteLine("Employee Menu");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Dislpay Employee Information");
                Console.WriteLine("3. View Employee Toadys Attandance");
                Console.WriteLine("4. Find Employee Today's Wage");
                Console.WriteLine("5. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        currentEmployee = utilityCall.AddEmployee();
                        break;
                    case 2:
                        if (currentEmployee != null)
                            utilityCall.DisplayEmployee(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;
                    case 3:
                        if (currentEmployee != null)
                            utilityCall.CheckAttendance(currentEmployee);
                        else
                            Console.WriteLine("No employee added yet");
                        break;
                    case 4:
                        if(currentEmployee != null)
                        {
                            utilityCall.CalculateDailyWage(currentEmployee);
                        }
                        else
                        {
                            Console.WriteLine("No Employee added yet");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exit the Program");
                        return;
                    default:
                        Console.WriteLine("Enter between 1-5");
                        return;
                }
            }
        }
    }
}


