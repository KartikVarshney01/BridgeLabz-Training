using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.TrafficManager
{
    internal class TrafficManagerMenu 
    {
        private VehicleUtilityImpl vehicleUtility;
        // Menu Class Containing the Program User Menu 
        public void Menu()
        {
            Console.WriteLine("Traffic Manager");
            Console.Write("Enter Road Capacity : ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            vehicleUtility = new VehicleUtilityImpl(capacity);

            while (true)
            {
                Console.WriteLine("====Traffic Manager====");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle");
                Console.WriteLine("3. Display Road");
                Console.WriteLine("4. Exit Program");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicleUtility.AddVehicle();
                        break;
                    case 2:
                        vehicleUtility.RemoveFromRoad();
                        break;
                    case 3:
                        vehicleUtility.DisplayRoad();
                        break;
                    case 4:
                        Console.WriteLine("Exiting The Intersection");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
