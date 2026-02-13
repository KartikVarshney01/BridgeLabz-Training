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
            // Taking Input Of The Citizen Population and The Zone And Sectors
            Console.Write("Enter Maximum Citizen Capacity : ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Of Zones : ");
            int zoneNumber = Convert.ToInt32(Console.ReadLine());

            CitizenRegistrationService service = new CitizenRegistrationService();
            CitizenPopulationManager manager = new CitizenPopulationManager(capacity,zoneNumber);

            // Initialize sectors dynamically
            for (int i = 0; i < zoneNumber; i++)
            {
                Console.Write($"Enter number of sectors in Zone {i}: ");
                int sectors = Convert.ToInt32(Console.ReadLine());
                manager.InitializeSectors(i, sectors);
            }

            // Infinte Loop
            while (true)
            {
                Console.WriteLine("\n===== TechVille Registration =====");
                Console.WriteLine("1. Register Citizen");
                Console.WriteLine("2. Search By ID");
                Console.WriteLine("3. Display All Citizens");
                Console.WriteLine("4. Show Zone Data");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1 :
                        Citizen citizen = new Citizen();
                        Console.WriteLine($"Generated Citizen ID: {citizen.CitizenID}");

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

                        Console.Write("Enter Zone: ");
                        int zone = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sector: ");
                        int sector = Convert.ToInt32(Console.ReadLine());

                        manager.AddCitizens(citizen,zone,sector);
                        Console.WriteLine("Citizen Registered Successfully!");
                        break;
                    case 2 : 
                        Console.Write("Enter Id To Search : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Citizen found = manager.SearchById(id);

                        if(found != null)
                        {
                            Console.WriteLine($"Found : {found.CitizenName}, Package : {found.ServicePackage}");
                        }
                        else
                        {
                            Console.WriteLine("Citizen Not Found");
                        }
                        break;
                    case 3 :
                        manager.DisplayAllCitizens();
                        break;
                    case 4 :
                        manager.DisplayZoneData();
                        break;
                    case 5 : 
                        Console.WriteLine("Exiting Program");
                        return;
                    default : 
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}