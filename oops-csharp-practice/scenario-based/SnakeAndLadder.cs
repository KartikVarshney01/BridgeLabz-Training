using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.scenario_based
{
    /* Writing a program for snake and ladder game by using arrays and functions to make a game of snake and ladders for players between 2 and 4.
     * 
     * version 1.0;
     */
    internal class SnakeAndLadder
    {
        static int[,] ladder = { { 5, 27 }, { 9, 51 }, { 22, 60 }, { 28, 54 }, { 44, 79 }, { 53, 69 }, { 66, 88 }, { 71, 92 }, { 85, 97 } };
        static int[,] snakes = { { 13, 7 }, { 37, 19 }, { 80, 43 }, { 86, 46 }, { 91, 49 }, { 99, 4 } };

        static void Main(String[] args)
        {
            SnakeAndLadder newgame = new SnakeAndLadder();
            newgame.SnakeAndLadderStart();
        }

        void SnakeAndLadderStart()
        {
            // Taking User Input for number of players
            Console.Write("Enter the number of players : ");
            int num = Convert.ToInt32(Console.ReadLine());
            // If player number is less than 2 or greater than 4 return invalid number
            if (num < 2 || num > 4)
            {
                Console.WriteLine("Invalid Number! Enter a number between 2 and 4.");
                return;
            }

            // Creating two arrays one for players name and other for their position
            string[] playersName = new string[num];
            int[] position = new int[num];

            // Taking Input data of the player 
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter the player {i + 1} name : ");
                playersName[i] = Console.ReadLine();
                position[i] = 0;
            }

            // Creating a bool variable to check whether a player has won the game or not
            bool gameCheck = false;

            while (!gameCheck)
            {
                // Running a loop so every player get a turn
                for (int i = 0; i < num; i++)
                {
                    Console.Write($"Player {i + 1} turn : ");
                    Console.Write("Press enter to roll dice");
                    Console.ReadLine();

                    int dice = RollDice();
                    int oldpos = position[i];

                    position[i] = MovePlayer(position[i], dice);
                    position[i] = SnakeAndLadderFun(position[i]);

                    Console.WriteLine($"Player {i + 1} : {oldpos} -> {position[i]}");

                    // Checking if current player wins the game or not, if does then break the loop
                    gameCheck = CheckWin(playersName[i], position[i]);
                    if (gameCheck) break;
                    Console.WriteLine();
                }
            }
        }

        // Getting a random dice number between 1 and 6
        static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        int MovePlayer(int pos, int dice)
        {
            if (pos + dice <= 100)
            {
                pos += dice;
            }
            else
            {
                Console.WriteLine("Move Skipped!");
            }
            return pos;
        }

        // Using Snakes and Ladders array to find positions of movement for each find
        int SnakeAndLadderFun(int position)
        {
            for (int i = 0; i < ladder.GetLength(0); i++)
            {
                if (position == ladder[i, 0])
                {
                    Console.WriteLine($"Ladder found from {position} -> {ladder[i, 1]}");
                    position = ladder[i, 1];
                    return position;
                }
            }
            for (int j = 0; j < snakes.GetLength(0); j++)
            {
                if (position == snakes[j, 0])
                {
                    Console.WriteLine($"Snake bites from {position} -> {snakes[j, 1]}");
                    position = snakes[j, 1];
                    return position;
                }
            }
            return position;
        }

        bool CheckWin(string playerName, int pos)
        {
            bool win = pos == 100 ? true : false;
            if (win)
            {
                Console.WriteLine($"Congratulations! The {playerName} won the Game.");
                Environment.Exit(0);
            }
            return win;
        }
    }
}
