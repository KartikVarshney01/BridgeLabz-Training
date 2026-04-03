using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.SmartHomeAutomation
{
    /// <summary>
    /// In the Program we got to learn and use oops methods to make it work by using class model of using different class for
    /// each in separate files so when there is a update we only need ot make a change in it and add a new interface for it to 
    /// work
    /// 
    /// version - 1.0
    /// </summary>
    internal class ApplianceMain
    {
        static void Main(string[] args)
        {
            Appliance[] appliances =
            {
                new Light("Living Room"),
                new Fan("BedRoom"),
                new AC("Hall")
            };

            Console.WriteLine("\nThe Appliances Turn On And Off");
            foreach (Appliance app in appliances)
            {
                Console.WriteLine("==============");
                Console.WriteLine(app);
                app.TurnOn();
                app.TurnOff();
                Console.WriteLine("==============");
            }
        }
    }
}
