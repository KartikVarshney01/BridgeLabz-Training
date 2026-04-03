using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation
{
    internal class HospitalSystem
    {
        static void Main()
        {
            Patient[] patients = new Patient[2];

            patients[0] = new InPatient(1, "Kartik", 22, 5, 3000);
            patients[1] = new OutPatient(2, "Aryan", 35, 800);

            foreach (Patient patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: {patient.CalculateBill()}");

                if (patient is IMedicalRecord record)
                {
                    record.AddRecord("General Checkup");
                    record.ViewRecords();
                }

                Console.WriteLine();
            }
        }
        // Interface IMedicalRecord
        interface IMedicalRecord
        {
            void AddRecord(string diagnosis);
            void ViewRecords();
        }

        // Abstract Derived Class
        abstract class Patient
        {
            private int patientId;
            private string name;
            private int age;

            private string diagnosis;
            private string medicalHistory;

            public int PatientId
            {
                get { return patientId; }
            }

            public string Name
            {
                get { return name; }
            }

            public int Age
            {
                get { return age; }
            }

            protected Patient(int patientId, string name, int age)
            {
                this.patientId = patientId;
                this.name = name;
                this.age = age;
            }

            public abstract double CalculateBill();

            public void GetPatientDetails()
            {
                Console.WriteLine("Patient ID: " + patientId);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            }

            protected void SetMedicalDetails(string diagnosis, string history)
            {
                this.diagnosis = diagnosis;
                this.medicalHistory = history;
            }

            protected void DisplayMedicalDetails()
            {
                Console.WriteLine("Diagnosis: " + diagnosis);
                Console.WriteLine("Medical History: " + medicalHistory);
            }
        }

        // InPatient Derived Class
        class InPatient : Patient, IMedicalRecord
        {
            private int daysAdmitted;
            private double dailyCharge;

            public InPatient(int id, string name, int age, int days, double charge)
                : base(id, name, age)
            {
                daysAdmitted = days;
                dailyCharge = charge;
            }

            public override double CalculateBill()
            {
                return daysAdmitted * dailyCharge;
            }

            public void AddRecord(string diagnosis)
            {
                SetMedicalDetails(diagnosis, "Admitted for treatment");
            }

            public void ViewRecords()
            {
                DisplayMedicalDetails();
            }
        }

        // OutPatient Derived Class
        class OutPatient : Patient, IMedicalRecord
        {
            private double consultationFee;

            public OutPatient(int id, string name, int age, double fee)
                : base(id, name, age)
            {
                consultationFee = fee;
            }

            public override double CalculateBill()
            {
                return consultationFee;
            }

            public void AddRecord(string diagnosis)
            {
                SetMedicalDetails(diagnosis, "Visited for consultation");
            }

            public void ViewRecords()
            {
                DisplayMedicalDetails();
            }
        }
    }
}
