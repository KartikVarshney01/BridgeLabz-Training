using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    /// <summary>
    /// The Program Hospital Management is used to help in getting to know about polymorphism,Encapsulation,Abstarction, And Inheritance.
    /// It takes doctor and patients and give their bill based on whether are they a In-Patient or a Out-Patient.
    /// 
    /// version-1.0
    /// </summary>
    internal class HospitalManagement
    {
        static void Main(string[] args)
        {
            // Taking Input for number of doctors and patients
            Console.Write("Enter number of doctors : ");
            int docCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of patients : ");
            int patientCount = Convert.ToInt32(Console.ReadLine());

            Hospital hospital = new Hospital(docCount, patientCount);

            while (true)
            {
                Console.WriteLine("\n1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. View Doctors");
                Console.WriteLine("4. View Patients");
                Console.WriteLine("5. Exit The Program");
                Console.Write("Enter Your choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        hospital.AddDoctor();
                        break;
                    case 2:
                        hospital.AddPatient();
                        break;
                    case 3:
                        hospital.ViewDoctors();
                        break;
                    case 4:
                        hospital.ViewPatients();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
    interface IPayable
    {
        int CalculateBill();
    }
    // Hospital Class To Initialize hospital and its array of both doctors and patients
    class Hospital
    {
        // Creating a array for both doctors and patients in hospital
        Doctor[] doctorsList;
        Patient[] patientsList;

        // Creating an index variable for both doc and patient array
        int docIdx = 0;
        int patIdx = 0;

        public Hospital(int docSize, int patSize)
        {
            doctorsList = new Doctor[docSize];
            patientsList = new Patient[patSize];
        }

        // Add Function to add a new Doctor
        public void AddDoctor()
        {
            // Checking if doctors list has space or not
            if (docIdx >= doctorsList.Length)
            {
                Console.WriteLine("Doctors Capacity Reached.");
                return;
            }

            // Taking Doctor Data input 

            Console.Write("Doctor Name: ");
            string name = Console.ReadLine();

            Console.Write("Specialization: ");
            string spec = Console.ReadLine();

            Console.Write("Consultancy Fee: ");
            int fee = Convert.ToInt32(Console.ReadLine());

            doctorsList[docIdx++] = new Doctor(name, spec, fee);
            Console.WriteLine("Doctor added successfully");
        }

        // Add Patients Function to add new Patient
        public void AddPatient()
        {
            // Checking if the doctors list is empty or not. If doctors list is empty then can't take a new patient.
            if (docIdx == 0)
            {
                Console.WriteLine("No doctors available currently. Add doctor first.");
                return;
            }

            if (patIdx >= patientsList.Length)
            {
                Console.WriteLine("Patient capacity full. Try Another Hospital");
                return;
            }

            // taking patient data
            Console.Write("Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ailment: ");
            string ailment = Console.ReadLine();

            Console.Write("Required Doctor Specialization: ");
            string reqSpec = Console.ReadLine();

            Console.WriteLine("\nMatching Doctors are : ");
            int count = 0;
            // Finding the doctors with same speciality as the requested
            for (int i = 0; i < docIdx; i++)
            {
                if (doctorsList[i].Specialization.Equals(reqSpec, StringComparison.OrdinalIgnoreCase))
                {
                    doctorsList[i].ViewDoctor(i);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No matching doctor found");
                return;
            }

            // Selecting the index of the doctor you want to consult with.
            Console.Write("Select Doctor Index: ");
            int docIndex = Convert.ToInt32(Console.ReadLine());
            Doctor assignedDoctor = doctorsList[docIndex];

            // Checking if doctor is admitting the patients or not.
            Console.Write("Doctor admits patient? (yes/no): ");
            string admit = Console.ReadLine();

            Patient patient;

            if (admit.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                // taking input for number of days a patient is admitted for. The patient is now a inpatient
                Console.Write("Enter admitted days: ");
                int days = Convert.ToInt32(Console.ReadLine());
                patient = new InPatient(name, age, ailment, assignedDoctor, days);
            }
            else
            {
                patient = new OutPatient(name, age, ailment, assignedDoctor);
            }

            patientsList[patIdx++] = patient;

            Bill bill = new Bill(patient);
            bill.GetBill();
            bill.ViewBill();
        }

        // Function to view Doctors 
        public void ViewDoctors()
        {
            if (docIdx == 0)
            {
                Console.WriteLine("No doctors added currently");
                return;
            }

            for (int i = 0; i < docIdx; i++)
                doctorsList[i].ViewDoctor(i);
        }

        // Function to view Patients
        public void ViewPatients()
        {
            if (patIdx == 0)
            {
                Console.WriteLine("No patients added");
                return;
            }

            for (int i = 0; i < patIdx; i++)
                patientsList[i].DisplayInfo();
        }

        // Doctor class to create doctor and its various fields
        class Doctor
        {
            // using get to make sure only privilaged fields can access it.
            public string Name { get; }
            public string Specialization { get; }
            public int ConsultancyFees { get; }

            public Doctor(string name, string specialization, int fees)
            {
                Name = name;
                Specialization = specialization;
                ConsultancyFees = fees;
            }

            public void ViewDoctor(int index)
            {
                Console.WriteLine($"[{index}] {Name} | {Specialization} | Fee: {ConsultancyFees}");
            }
        }
        class Patient : IPayable
        {
            protected string name;
            protected int age;
            protected string ailment;
            protected Doctor doctor;
            protected bool admitted;

            public string Name => name;
            public int Age => age;
            public string Ailment => ailment;
            public Doctor AssignedDoctor => doctor;

            public Patient(string name, int age, string ailment, Doctor doctor)
            {
                this.name = name;
                this.age = age;
                this.ailment = ailment;
                this.doctor = doctor;
            }

            public virtual int CalculateBill()
            {
                return doctor.ConsultancyFees;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Patient: {name}, Age: {age}, Doctor: {doctor.Name}");
            }
        }

        // Class InPatient for patients who stay for a number of days or overnight
        class InPatient : Patient
        {
            int days;
            const int dailyCharge = 2000;

            public InPatient(string name, int age, string ailment, Doctor doctor, int days)
                : base(name, age, ailment, doctor)
            {
                this.days = days;
                admitted = true;
            }

            public override int CalculateBill()
            {
                return doctor.ConsultancyFees + (days * dailyCharge);
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"InPatient: {name}, Days: {days}, Doctor: {doctor.Name}");
            }
        }

        // Out Patient class for patients who does not stay for any night in the hospital
        class OutPatient : Patient
        {
            public OutPatient(string name, int age, string ailment, Doctor doctor)
                : base(name, age, ailment, doctor)
            {
                admitted = false;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"OutPatient: {name}, Consultation with {doctor.Name}");
            }
        }

        // Bill Class for getting the bill
        class Bill
        {
            Patient patient;
            int amount;

            public Bill(Patient patient)
            {
                this.patient = patient;
            }

            public void GetBill()
            {
                amount = patient.CalculateBill();
            }

            public void ViewBill()
            {
                Console.WriteLine($"Total Bill Amount: {amount}");
            }
        }
    }
}
