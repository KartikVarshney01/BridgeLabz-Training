using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_keyword
{
    internal class HospitalSystem
    {
        public static string HospitalName = "City Care Hospital";
        private static int totalPatients = 0;

        public readonly int PatientID;
        public string Name;
        public int Age;
        public string Ailment;

        public HospitalSystem(int PatientID, string Name, int Age, string Ailment)
        {
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            totalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients : " + totalPatients);
        }

        public static void DisplayPatientDetails(object obj)
        {
            if (obj is HospitalSystem p)
            {
                Console.WriteLine("Hospital  : " + HospitalName);
                Console.WriteLine("PatientID : " + p.PatientID);
                Console.WriteLine("Name      : " + p.Name);
                Console.WriteLine("Age       : " + p.Age);
                Console.WriteLine("Ailment   : " + p.Ailment);
            }
            else
            {
                Console.WriteLine("Invalid Patient Object");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            HospitalSystem p1 = new HospitalSystem(501, "Suresh", 45, "Fever");
            HospitalSystem p2 = new HospitalSystem(502, "Anita", 30, "Migraine");

            HospitalSystem.DisplayPatientDetails(p1);
            Console.WriteLine();
            HospitalSystem.DisplayPatientDetails(p2);
            Console.WriteLine();
            HospitalSystem.GetTotalPatients();
        }
    }
}
