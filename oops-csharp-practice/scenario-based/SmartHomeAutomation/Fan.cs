using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    // Dericed Class Fan inherting Appliance 
    class Fan : Appliance
    {
        public Fan(string applianceName) : base(applianceName) { }

        public override void TurnOn()
        {
            Console.WriteLine($"The Fan inside {ApplianceName} Turns On.");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"The Fan inside {ApplianceName} Turn Off.");
        }
    }
}
