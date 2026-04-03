using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class AmbulanceMenu
    {
        private IAmbulance utility = new AmbulanceUtility();

        public void HospitalMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== Ambulance Route Menu ===");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Remove Patient");
                Console.WriteLine("3. Toggle Maintenance");
                Console.WriteLine("4. Display Hospital Status");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: utility.AddPatient(); break;
                    case 2: utility.RemovePatient(); break;
                    case 3: utility.ToggleMaintenance(); break;
                    case 4: utility.DisplayStatus(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }
    }
}
