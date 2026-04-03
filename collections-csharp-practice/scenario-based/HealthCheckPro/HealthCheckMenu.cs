using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.HealthCheckPro
{
    internal class HealthCheckMenu
    {
        private readonly IHealthCheck healthCheck;

        public HealthCheckMenu()
        {
            healthCheck = new HealthCheckUtilityImpl();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n=== HealthCheckPro API Validator ===");
                Console.WriteLine("1. Scan LabTest Controller");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        healthCheck.ScanController(typeof(LabTestController));
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
