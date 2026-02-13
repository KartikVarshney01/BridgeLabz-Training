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
            // Creating the Service Reference 
            CitizenRegistrationService service = new CitizenRegistrationService();

            Console.WriteLine("===== TechVille Service Eligibility System =====\n");

            // Infinte Loop
            while (true)
            {
                Citizen citizen = new Citizen();

                Console.Write("Enter Name: ");
                citizen.CitizenName = Console.ReadLine();

                Console.Write("Enter Age: ");
                citizen.CitizenAge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Annual Income: ");
                citizen.AnnualIncome = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Residency Years: ");
                citizen.ResidencyYears = Convert.ToInt32(Console.ReadLine());

                // Basic Validation
                if (!InputValidator.IsValidAge(citizen.CitizenAge) ||
                    !InputValidator.IsValidIncome(citizen.AnnualIncome) ||
                    !InputValidator.IsValidResidency(citizen.ResidencyYears))
                {
                    Console.WriteLine("Invalid data. Try again.\n");
                    continue;
                }

                // Calculating & Assigning The Eligibility and Package
                service.CalculateEligibility(citizen);
                service.AssignServicePackage(citizen);

                // Displaying Output
                Console.WriteLine("\n===== Citizen Details =====");
                Console.WriteLine($"Name: {citizen.CitizenName}");
                Console.WriteLine($"Eligibility Score: {citizen.EligibilityScore}");
                Console.WriteLine($"Package: {citizen.ServicePackage}");

                // Checking for next entry by using - Continue or break
                Console.Write("\nRegister another citizen? (Y/N): ");
                string choice = Console.ReadLine().ToUpper();

                if (choice != "Y")
                    break;
            }
            Console.WriteLine("\nExiting The Program.");
        }
    }
}