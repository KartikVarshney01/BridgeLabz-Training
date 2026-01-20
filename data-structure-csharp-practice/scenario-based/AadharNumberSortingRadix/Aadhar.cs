using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AadharNumberSortingRadix
{
    // Encapsulated Aadhar Class
    internal class Aadhar
    {
        public long AadharNumber { get; set; }

        public override string ToString()
        {
            return $"Aadhar Number : {AadharNumber}";
        }
    }
}
