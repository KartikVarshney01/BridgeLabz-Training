using System;
using TechVille.Modules;

namespace TechVille.Service
{
    public class CitizenRegistrationService
    {
        public void CalculateEligibility(Citizen citizen)
        {
            int ageScore = citizen.CitizenAge >= 18 ? 20 : 0;
            int residencyScore = citizen.ResidencyYears * 5;
            int incomeScore = citizen.AnnualIncome < 300000 ? 30 : 10;

            citizen.EligibilityScore = ageScore + residencyScore + incomeScore;
            citizen.IsEligible = citizen.CitizenAge >= 18;
        }
    }
}