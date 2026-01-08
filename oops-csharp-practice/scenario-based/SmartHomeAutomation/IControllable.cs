using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    // Interface class providing interface for turning appliances on and off
    interface IControllable
    {
        void TurnOn();

        void TurnOff();
    }
}
