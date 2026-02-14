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
                Console.WriteLine("3. Search By Name");
                Console.WriteLine("4. Display All Citizens");
                Console.WriteLine("5. Show Zone Data");
                Console.WriteLine("6. Exit");
                Console.Write("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1 :
                        Console.Write("Enter Name: ");
                        string name = CitizenUtility.FormatName(Console.ReadLine());

                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();
                        if (!InputValidator.IsValidEmail(email))
                        {
                            Console.WriteLine("Invalid Email.");
                            continue;
                        }

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Annual Income: ");
                        double income = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter Residency Years: ");
                        int years = Convert.ToInt32(Console.ReadLine());

                        // Basic Validation
                        if (!InputValidator.IsValidAge(age) ||
                            !InputValidator.IsValidIncome(income) ||
                            !InputValidator.IsValidResidency(years))
                        {
                            Console.WriteLine("Invalid data. Try again.\n");
                            continue;
                        }

                        Citizen citizen = new Citizen();
                        citizen.CitizenName = name;
                        citizen.CitizenEmail = email;
                        citizen.CitizenAge = age;
                        citizen.AnnualIncome = income;
                        citizen.ResidencyYears = years;
                        // Console.WriteLine($"Generated Citizen ID: {citizen.CitizenID}");

                        // Calculating & Assigning The Eligibility and Package
                        service.CalculateEligibility(citizen);
                        service.AssignServicePackage(citizen);

                        Console.Write("Enter Zone: ");
                        int zone = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Sector: ");
                        int sector = Convert.ToInt32(Console.ReadLine());

                        manager.AddCitizens(citizen,zone,sector);
                        break;
                    case 2 : 
                        Console.Write("Enter Id To Search : ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Citizen isIdfound = manager.SearchById(id);

                        if(isIdfound != null)
                        {
                            Console.WriteLine($"Found : {isIdfound.CitizenName}, Package : {isIdfound.ServicePackage}");
                        }
                        else
                        {
                            Console.WriteLine("Citizen Not Found");
                        }
                        break;
                    case 3 :
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();

                        Citizen isNamefound = manager.SearchByName(name);

                        if (isNamefound != null)
                            Console.WriteLine($"Found: {isNamefound.CitizenName}");
                        else
                            Console.WriteLine("Citizen Not Found.");
                        break;
                    case 4 :
                        manager.DisplayAllCitizens();
                        break;
                    case 5 :
                        manager.DisplayZoneData();
                        break;
                    case 6 : 
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