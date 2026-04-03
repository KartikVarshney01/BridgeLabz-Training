using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.FitnessTracker
{
    // Utility Class Containing Methods Implementation for ITracker
    internal class FitnessTrackerUtilityImpl : ITracker
    {
        // Creating A Users Array To Store User Data
        private User[] users;
        // Creating Random Method Variable
        private Random random;
        // Creating Max Capacity And Current Capacity Variables To Store Max And Current Number of Users
        private int MaxCapacity;
        private int currentCapacity;

        // Constructor
        public FitnessTrackerUtilityImpl()
        {
            MaxCapacity = 20;
            currentCapacity = 0;
            users = new User[MaxCapacity];
            random = new Random();
        }

        // Add User Method To Add A new User
        public void AddUser()
        {
            if(currentCapacity >= MaxCapacity)
            {
                Console.WriteLine("Users Are Full.");
                return;
            }

            User newUser = new User();
            users[currentCapacity++] = newUser;

            Console.WriteLine("------------------------------------");
            Console.WriteLine($" User Added Successfully");
            Console.WriteLine($"User ID     : {newUser.UserId}");
            Console.WriteLine($"Step Count  : {newUser.StepCount}");
            Console.WriteLine($"Total Users : {currentCapacity}/{MaxCapacity}");
            Console.WriteLine("------------------------------------");

        }

        // Method To Update The LeaderBoard On Every Increase StepCount
        public void LeaderBoardUpdate()
        {
            // Checking If There is Any User in The Array
            if (currentCapacity <= 0)
            {
                Console.WriteLine("No Users");
                return;
            }

            // Updating User Step Count
            for(int i = 0; i < currentCapacity; i++)
            {
                users[i].StepCount = random.Next(1, 100);
            }

            // Using Bubble Sort To Update LeaderBoard
            for(int i = 0; i < currentCapacity; i++)
            {
                bool isSorted = true;
                for(int j = 0; j < currentCapacity-i-1; j++)
                {
                    if (users[j].StepCount < users[j + 1].StepCount)
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    Console.WriteLine("\n Leaderboard Updated Successfully!\n");
                    return;
                }
            }
        }

        // Method To Show LeadBorad
        public void ShowLeaderBoard()
        {
            if(currentCapacity <= 0)
            {
                Console.WriteLine("No Users");
                return;
            }

            Console.WriteLine("\n====================================");
            Console.WriteLine("           🏆 LEADERBOARD 🏆         ");
            Console.WriteLine("====================================");
            Console.WriteLine("Rank | User ID | Steps");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < currentCapacity; i++)
            {
                Console.WriteLine(
                    $"{(i + 1),-4} | {users[i].UserId,-7} | {users[i].StepCount}"
                );
            }

            Console.WriteLine("====================================\n");
        }

    }
}
