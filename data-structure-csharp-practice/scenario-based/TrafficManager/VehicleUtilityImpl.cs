using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.TrafficManager
{
    // Class Containing Vehicle Implementation
    internal class VehicleUtilityImpl : IVehicle
    {
        // Private Fields For Total Capacity And Current Capacity
        private int totalCapacity;
        private int currentCapacity;

        // Creating Queue TO Store The Vehicle Before They Go The Road
        Queue<VehicleNode> VehicleWaiting;
        
        private VehicleNode Head;
        private VehicleNode Tail;

        // Constructor The Utility And Total Capacity
        public VehicleUtilityImpl(int capacity)
        {
            this.totalCapacity = capacity;
            currentCapacity = 0;
            VehicleWaiting = new Queue<VehicleNode>();
        }

        // Method To Add A New Vehicle in the queue
        public void AddVehicle()
        {
            VehicleNode currentVehicle = new VehicleNode();
            VehicleWaiting.Enqueue(currentVehicle);
            AddToRoad();
        }

        // Method To Add The Vehicle From Queue To Road.
        public void AddToRoad()
        {
            if (currentCapacity >= totalCapacity)
            {
                Console.WriteLine("Currently Road Capacity is Full. Wait For a Vehicle To Exit First");
                return;
            }
            while(VehicleWaiting.Count > 0 && currentCapacity < totalCapacity)
            {
                VehicleNode currentVehicle = VehicleWaiting.Dequeue();
                // Case 1: First vehicle
                if (Head == null)
                {
                    Head = currentVehicle;
                    Tail = currentVehicle;
                    currentVehicle.Next = Head; // circular link
                }
                // Case 2: Add at end
                else
                {
                    Tail.Next = currentVehicle;
                    Tail = currentVehicle;
                    Tail.Next = Head; // maintain circular link
                }
                currentCapacity++;
                Console.WriteLine($"Vehicle '{currentVehicle.VehicleId}' entered the roundabout.");
                Console.WriteLine($"Current Capacity: {currentCapacity}/{totalCapacity}");

                if (currentCapacity == totalCapacity && VehicleWaiting.Count > 0)
                {
                    Console.WriteLine("Roundabout full. Vehicles waiting...");
                }
            }
        }

        // Method To Remove A Vehicle From Road
        public void RemoveFromRoad()
        {
            if(Head == null && Tail == null)
            {
                Console.WriteLine("No vehicle On The Roundabout");
                return;
            }

            VehicleNode removeVehicle = Head;

            // Removing vehicle At Head
            if(Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Next = Head.Next;
                Head = Head.Next;
            }
            currentCapacity--;

            Console.WriteLine($"Vehicle '{removeVehicle.VehicleId}' exited the roundabout.");
            Console.WriteLine($"Current Capacity: {currentCapacity}/{totalCapacity}");

            AddToRoad();
        }

        // Display circular linked list
        public void DisplayRoad()
        {
            if (Head == null)
            {
                Console.WriteLine("Roundabout is empty");
                return;
            }

            Console.WriteLine("Vehicles on Roundabout:");
            VehicleNode temp = Head;

            do
            {
                Console.Write($"[{temp.VehicleId}] -> ");
                temp = temp.Next;
            }
            while (temp != Head);

            Console.WriteLine($"Capacity: {currentCapacity}/{totalCapacity}");
        }
    }
}
