using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.AadharNumberSortingRadix
{
    internal class AadharNumberMain
    {
        /// <summary>
        /// The Program of Aadhar Number Sorting Helps Us in learning about radix sort and its implementation.
        /// It takes aadhar number (12 digits) and sorts them using radix sort and then search a specific aadhar using binary search
        /// 
        /// version - 1.0
        /// </summary>
        static void Main(string[] args)
        {
            AadharNumberMenu start = new AadharNumberMenu();
            start.Menu();
        }
    }
}
