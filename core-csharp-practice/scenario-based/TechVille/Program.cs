using System;
using TechVille.Modules;
using TechVille.Service;
using TechVille.Utilities;

namespace TechVille
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("===== TechVille Citizen Registration Portal =====\n");

            Citizen citizen = new Citizen();

            // Taking User Input
            Console.Write("Enter Name: ");
            citizen.CitizenName = Console.ReadLine();

            Console.Write("Enter Age: ");
            citizen.CitizenAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Annual Income: ");
            citizen.AnnualIncome = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            citizen.ResidencyYears = Convert.ToInt32(Console.ReadLine());

            // Validation Of Age, Income And Residency years
            if (!InputValidator.IsValidAge(citizen.CitizenAge) ||
                !InputValidator.IsValidIncome(citizen.AnnualIncome) ||
                !InputValidator.IsValidResidency(citizen.ResidencyYears))
            {
                Console.WriteLine("\nInvalid Input Provided.");
                return;
            }

            // Process
            CitizenRegistrationService service = new CitizenRegistrationService();
            service.CalculateEligibility(citizen);

            // Output
            Console.WriteLine("\n===== Registration Details =====");
            Console.WriteLine($"Name: {citizen.CitizenName}");
            Console.WriteLine($"Age: {citizen.CitizenAge}");
            Console.WriteLine($"Income: {citizen.AnnualIncome}");
            Console.WriteLine($"Residency Years: {citizen.ResidencyYears}");
            Console.WriteLine($"Eligibility Score: {citizen.EligibilityScore}");
            Console.WriteLine($"Status: {(citizen.IsEligible ? "Eligible" : "Not Eligible")}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}