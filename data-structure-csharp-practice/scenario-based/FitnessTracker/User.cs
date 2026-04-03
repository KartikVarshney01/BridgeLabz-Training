using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FitnessTracker
{
    // Encapsulated User Class Containing Fields of a user
    internal class User
    {
        private static int NextId = 1;
        public int UserId { get; }
        public int StepCount { get; set; }

        public User()
        {
            this.UserId = NextId++;
        }

        public override string ToString()
        {
            return $"{UserId} ---- > {StepCount}";
        }
    }
}
