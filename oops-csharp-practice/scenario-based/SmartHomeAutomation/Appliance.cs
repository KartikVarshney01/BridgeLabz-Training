using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    abstract class Appliance : IControllable
    {
        // private variables for the appliances
        private string applianceName; // Appliance Name

        public Appliance(string applianceName)
        {
            this.applianceName = applianceName;
        }

        // Getter and Setter
        public string ApplianceName
        {
            get { return applianceName; }
            set { applianceName = value; }
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public override string ToString()
        {
            return $"Place = {applianceName}";
        }
    }
}
