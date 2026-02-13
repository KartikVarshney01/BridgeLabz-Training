using System;

namespace TechVille.Modules
{
    public class Citizen
    {
        public string CitizenName {get; set;}
        public int CitizenAge {get; set;}
        public double AnnualIncome {get; set;}
        public int ResidencyYears {get; set;}
        public int EligibilityScore {get; set;}
        public bool IsEligible {get; set;}
        public string ServicePackage {get; set;} // Module - 2 : Adding Service Package
    }
}