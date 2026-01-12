using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal interface IApprovable
    {
        bool ApproveLoan(Applicant applicant);
        double CalculateEMI(double amount); 
    }
}
