using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.TrafficManager
{
    internal class TrafficManagerMain
    {
        /// <summary>
        /// The Program Traffic Manager Uses Circular Linked List And Queue To Implement a System Where New Vehicle Enters A Queue 
        /// First and Then If There is Space on The Road Then Go To There OtherWise Remains There Untill A space appears on the road.
        /// We Have :
        ///             1. Add Or Remove Cars in Circular Path.
        ///             2. Queue UnderFlow/OverFlow Handling By Showing
        ///                1. UnderFlow - No Vehicle Then Empty Road Message
        ///                2. OverFlow - RoadFull - Vehicle Stays in Queue
        ///             3. Print/Display Road Status
        ///             
        /// version - 1.0
        /// </summary>
        static void Main(String[] args)
        {
            TrafficManagerMenu start = new TrafficManagerMenu();
            start.Menu();
        }
    }
}
