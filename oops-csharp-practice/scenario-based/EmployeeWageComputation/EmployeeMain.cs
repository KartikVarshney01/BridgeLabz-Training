using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    /// <summary>
    /// The program function or purpose is to take helps us in learning about how to works on uc's and implement
    /// them accordingly.
    /// 1. In 1st UC it takes a random attendance from random function of whether a user is present today or not.
    /// 
    /// version - 1.0
    /// </summary>
    internal class EmployeeMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeMenu menu = new EmployeeMenu();
            menu.EmployeeChoice();

        }
    }
}
