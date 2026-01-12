using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    abstract class LoanApplication : IApprovable
    {
        public string LoanType;
        public int Term;             
        public double InterestRate;

        protected bool isApproved;

        public LoanApplication(string loanType, int term, double interestRate)
        {
            LoanType = loanType;
            Term = term;
            InterestRate = interestRate;
        }

        public abstract bool ApproveLoan(Applicant applicant);
        public abstract double CalculateEMI(double amount);

        public bool IsApproved()
        {
            return isApproved;
        }
    }
}
