using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FitnessTracker
{
    // Menu Class Containing User Menu
    internal class FitnessTrcakerMenu
    {
        // Private reference for the Fitness Trcaker Utility
        private FitnessTrackerUtilityImpl fitUtility;
        public void Menu()
        {
            fitUtility = new FitnessTrackerUtilityImpl();
            
            // Infinite Loop
            while (true)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine("          FITNESS TRACKER         ");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Update Leaderboard");
                Console.WriteLine("3. Show Leaderboard");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        fitUtility.AddUser();
                        break;
                    case 2:
                        fitUtility.LeaderBoardUpdate();
                        break;
                    case 3:
                        fitUtility.ShowLeaderBoard();
                        break;
                    case 4:
                        Console.WriteLine("Exiting The Fitness Tracker");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
