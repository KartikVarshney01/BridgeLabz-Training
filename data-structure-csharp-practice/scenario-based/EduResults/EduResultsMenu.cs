using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.scenario_based.EduResults
{
    internal class EduResultsMenu
    {
        private EduResultsUtilityImpl EduUtility;

        public EduResultsMenu()
        {
            EduUtility = new EduResultsUtilityImpl();
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Welcome To The Edu. Results");
                Console.WriteLine("1. Add Students And Districts");
                Console.WriteLine("2. Get State Rank List (Combined)");
                Console.WriteLine("3. Get State Rank List (Separate)");
                Console.WriteLine("4. Exit The Program");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EduUtility.AddMarks();
                        break;
                    case 2:
                        EduUtility.MergeMarks();
                        break;
                    case 3:
                        EduUtility.DistrictRank();
                        break;
                    case 4:
                        Console.WriteLine("Exiting .... ");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
