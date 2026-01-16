using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.TrafficManager
{
    // Encapsulated Vehicle Node
    internal class VehicleNode
    {
        public static int Id = 101;
        public int VehicleId { get; set; }
        public VehicleNode Next { get; set; }

        public VehicleNode()
        {
            this.VehicleId = Id++;
        }
    }
}
