using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    // Dericed Class AC inherting Appliance 
    class AC : Appliance
    {
        public AC(string applianceName) : base(applianceName) { }

        public override void TurnOn()
        {
            Console.WriteLine($"The AC inside {ApplianceName} Turns On And Blasts Cool Air");
        }
        public override void TurnOff()
        {
            Console.WriteLine($"The AC inside {ApplianceName} Turn Off.");
        }
    }
}
