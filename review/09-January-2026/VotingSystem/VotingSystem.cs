using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Review.VotingSystem
{
    internal class VotingSystem
    {
        static string[] candidateName = new string[2]; // Candidate Name 
        static int[] candidateVotes = new int[2]; // Current Votes
        static string[] votersNamelist = new string[5];
        static int[] voterslist = new int[5];
        static void Main(string[] args)
        {
            VotingSystem vote = new VotingSystem();
            vote.Menu();
        }

        void Menu()
        {
            while (true)
            {
                Console.WriteLine("Voting System");
                Console.WriteLine("1. Admin Role");
                Console.WriteLine("2. View Candidate List");
                Console.WriteLine("3. Taking Voter Details.");
                Console.WriteLine("4. Give Votes");
                Console.WriteLine("5. Program Exit");
                Console.Write("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AdminRole();
                        break;
                    case 2:
                        DisplayCandidateDetails();
                        break;
                    case 3:
                        VotersInput();
                        break;
                    case 4:
                        Voting();
                        break;
                    case 5:
                        Console.WriteLine("Exiting The Program");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        static void AdminRole()
        {
            Console.WriteLine("Enter 2 Candidate Details : ");
            Console.Write("Enter 1st Candidate Name : ");
            string name1 = Console.ReadLine();
            Console.Write("Enter 2nd Candidate Name : ");
            string name2 = Console.ReadLine();

            candidateName[0] = name1;
            candidateName[1] = name2;
            candidateVotes[0] = 0;
            candidateVotes[1] = 0;
        }
        void DisplayCandidateDetails()
        {
            Console.WriteLine("Candidate Name | Votes");
            for (int i = 0; i < candidateName.Length; i++)
            {
                Console.WriteLine($"{candidateName[i]} | {candidateVotes[i]}");
            }
        }

        void VotersInput()
        {
            for (int i = 0; i < votersNamelist.Length; i++)
            {
                Console.Write($"Enter {i + 1} voter name : ");
                string name = Console.ReadLine();
                votersNamelist[i] = name;
            }
        }

        void Voting()
        {
            for (int i = 0; i < votersNamelist.Length; i++)
            {
                Console.Write($"Enter your voting candidate number (1,2) : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    candidateVotes[0]++;
                }
                else if (choice == 2)
                {
                    candidateVotes[1]++;
                }
                else
                {
                    Console.WriteLine("You Have Voted for No Candidate.");
                }
            }
            DisplayCandidateDetails();
            DisplayResult();
        }

        void DisplayResult()
        {
            Console.WriteLine(candidateVotes[0] > candidateVotes[1] ? $"The Candidate {candidateName[0]} Wins"
                : $"The Candidate {candidateName[1]} Wins");
        }
    }
}
