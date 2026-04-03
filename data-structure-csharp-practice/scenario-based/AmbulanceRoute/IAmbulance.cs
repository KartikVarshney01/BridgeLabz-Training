using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AmbulanceRoute
{
    internal interface IAmbulance
    {
        void AddPatient();
        void RemovePatient();
        void ToggleMaintenance();
        void DisplayStatus();
    }
}
