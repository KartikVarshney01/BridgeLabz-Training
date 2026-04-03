using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    // Dericed Class Light inherting Appliance 
    class Light : Appliance
    {
        public Light(string applianceName) : base(applianceName) { }

        public override void TurnOn()
        {
            Console.WriteLine($"Light inside {ApplianceName} Turns On.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"Light inside {ApplianceName} Turns Off");
        }
    }
}
