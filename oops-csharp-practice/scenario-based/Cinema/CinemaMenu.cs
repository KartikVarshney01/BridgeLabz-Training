using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Cinema
{
    // Class Menu that contains the Main Part or Starting part of the program and show user menu and call other functions
    internal class CinemaMenu
    {
        ICinema utility;

        public void Menu()
        {
            utility = new CinemaUtilityImpl();

            // Infinite While Loop
            while (true)
            {
                Console.WriteLine("====Cinema Time====");
                Console.WriteLine("1. Add A New Movie");
                Console.WriteLine("2. Search A Movie By Keyword");
                Console.WriteLine("3. Display All Movies");
                Console.WriteLine("4. Exit The Cinema");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddMovie();
                        break;
                    case 2:
                        utility.SearchMovie();
                        break;
                    case 3:
                        utility.DisplayAllMovies();
                        break;
                    case 4:
                        Console.WriteLine("Exiting The Cinema");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
