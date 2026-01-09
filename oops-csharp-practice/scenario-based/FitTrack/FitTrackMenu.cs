using BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    // Menu Class Containing the menu for starting the program
    internal class FitTrackMenu
    {
        public void Start()
        {
            Console.Write("Enter User ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Height (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Enter Weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            UserProfile user = new UserProfile(id, name, age, height, weight);
            user.DisplayUser();

            while (true)
            {
                Console.WriteLine("\nChoose Workout Type:");
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. Exit The Program");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Workout workout;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Duration in minutes : ");
                        int durationCardio = Convert.ToInt32(Console.ReadLine());
                        workout = new CardioWorkout(durationCardio);
                        workout.TrackWorkout();
                        Console.WriteLine($"Calories Burned: {workout.CalorieBurned()}");
                        break;
                    case 2:
                        Console.Write("Enter Duration in minutes : ");
                        int durationStrength = Convert.ToInt32(Console.ReadLine());
                        workout = new StrengthWorkout(durationStrength);
                        workout.TrackWorkout();
                        Console.WriteLine($"Calories Burned: {workout.CalorieBurned()}");
                        break;
                    case 3:
                        Console.WriteLine("Exiting The Program");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice! Enter betweeen 1-3");
                        break;
                }
            }
            
        }
    }
}
