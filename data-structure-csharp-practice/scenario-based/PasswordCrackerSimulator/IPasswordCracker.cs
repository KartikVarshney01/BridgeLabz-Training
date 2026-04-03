using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.PasswordCrackerSimulator
{
    // Interface Class 
    internal interface IPasswordCracker
    {
        void SetPassword();
        void GenerateDecodePassword(); // Scenario - A
        void FindPassword(); // Scenario - B
    }
}
