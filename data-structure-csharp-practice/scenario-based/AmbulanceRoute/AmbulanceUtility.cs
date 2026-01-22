using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AmbulanceRoute
{
    internal class AmbulanceUtility : IAmbulance
    {
        private HospitalUnitList hospital;

        public AmbulanceUtility()
        {
            hospital = new HospitalUnitList();
            CreateHospital();
        }

        private void CreateHospital()
        {
            hospital.AddUnit("Emergency");
            hospital.AddUnit("Radiology");
            hospital.AddUnit("Surgery");
            hospital.AddUnit("ICU");
        }

        public void AddPatient()
        {
            Console.Write("Enter Patient Name: ");
            hospital.AddPatient(Console.ReadLine());
        }

        public void RemovePatient()
        {
            Console.Write("Enter Patient Name: ");
            hospital.RemovePatient(Console.ReadLine());
        }

        public void ToggleMaintenance()
        {
            Console.Write("Enter Unit Name: ");
            string unit = Console.ReadLine();

            Console.Write("Enter status (true = Active, false = Maintenance): ");
            bool status = Convert.ToBoolean(Console.ReadLine());

            hospital.ToggleMaintenance(unit, status);
        }

        public void DisplayStatus()
        {
            hospital.DisplayStatus();
        }
    }
}
