using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FitnessTracker
{
    // Interface Class Containing contract for the methods or providing interface
    internal interface ITracker
    {
        void AddUser(); // Method To Add New User
        void LeaderBoardUpdate(); // To Update The LeaderBoard On Every Step Increase
        void ShowLeaderBoard(); // Method To Display ScoreBoard
    }
}
