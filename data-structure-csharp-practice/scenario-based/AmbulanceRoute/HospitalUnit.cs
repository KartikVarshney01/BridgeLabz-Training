using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class HospitalUnitNode
    {
        public string UnitName { get; set; }
        public bool IsAvailable { get; set; }
        public string PatientName { get; set; }
        public HospitalUnitNode Next { get; set; }
    }

    internal class HospitalUnitList
    {
        private HospitalUnitNode Head;
        private HospitalUnitNode Tail;
        private int size = 0;

        public void AddUnit(string unitName)
        {
            HospitalUnitNode newUnit = new HospitalUnitNode
            {
                UnitName = unitName,
                IsAvailable = true
            };

            if (size == 0)
            {
                Head = Tail = newUnit;
                newUnit.Next = Head;
            }
            else
            {
                Tail.Next = newUnit;
                Tail = newUnit;
                Tail.Next = Head;
            }
            size++;
        }

        public void AddPatient(string patientName)
        {
            HospitalUnitNode temp = Head;

            while (true)
            {
                Console.WriteLine($"Checking {temp.UnitName}...");

                if (temp.IsAvailable)
                {
                    temp.PatientName = patientName;
                    temp.IsAvailable = false;
                    Console.WriteLine($"Patient admitted to {temp.UnitName}");
                    return;
                }

                temp = temp.Next;
                if (temp == Head) break;
            }

            Console.WriteLine("No unit available for emergency!");
        }

        public void RemovePatient(string patientName)
        {
            HospitalUnitNode temp = Head;

            while (true)
            {
                if (temp.PatientName != null && temp.PatientName.Equals(patientName))
                {
                    temp.PatientName = null;
                    temp.IsAvailable = true;
                    Console.WriteLine($"Patient discharged from {temp.UnitName}");
                    return;
                }

                temp = temp.Next;
                if (temp == Head) break;
            }

            Console.WriteLine("Patient not found");
        }

        public void ToggleMaintenance(string unitName, bool isAvailable)
        {
            HospitalUnitNode temp = Head;

            while (true)
            {
                if (temp.UnitName.Equals(unitName))
                {
                    temp.IsAvailable = isAvailable;
                    Console.WriteLine(isAvailable ? $"{unitName} is now Active" : $"{unitName} is Under Maintenance");
                    return;
                }

                temp = temp.Next;
                if (temp == Head) break;
            }

            Console.WriteLine("Unit not found");
        }

        // Display current status Method
        public void DisplayStatus()
        {
            if (Head == null)
            {
                Console.WriteLine("No hospital units available");
                return;
            }

            HospitalUnitNode temp = Head;
            Console.WriteLine("\n--- Hospital Unit Status ---");

            do
            {
                Console.WriteLine($"Unit: {temp.UnitName} | " + $"Status: {(temp.IsAvailable ? "Available" : "Occupied / Maintenance")} | " +
                    $"Patient: {(temp.PatientName ?? "None")}"
                );

                temp = temp.Next;
            } while (temp != Head);

            Console.WriteLine("-----------------------------\n");
        }
    }
}