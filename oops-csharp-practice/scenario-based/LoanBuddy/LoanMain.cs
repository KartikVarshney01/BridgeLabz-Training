using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class LoanMain
    {
        static void Main(string[] args)
        {
            LoanMenu menu = new LoanMenu();
            menu.Menu();
        }
    }
}
