using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.EmployeeWageComputation
{
    /// <summary>
    /// The program function or purpose is to take helps us in learning about how to works on uc's and implement
    /// them accordingly.
    /// 1. In 1st UC it takes a random attendance from random function of whether a user is present today or not.
    /// 2. In 2nd UC we calculate the daily wage of a employee depending if he is present or not.
    /// 3. In 3rd UC we calculate part time check and wage calculation
    /// 4. In 4th UC we implement switch case in the program
    /// 5. In 5th UC we implement calculating monthly wages of a employee
    /// 6. In 6th UC we implement calculating wage untill a maximum hours limit or a month is reached.
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
