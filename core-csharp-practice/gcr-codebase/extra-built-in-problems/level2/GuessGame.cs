using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_built_in_problems.level2
{
    internal class GuessGame
    {
        static void Main(String[] args)
        {
            // Taking User Input
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Give feedback : h = Too High | l = Too Low | c = Correct\n");

            int low = 1;
            int high = 100;
            bool Check = false;

            Random random = new Random();

            while (!Check)
            {
                int guess = RandomGuessFun(random, low, high);
                Console.WriteLine($"Computer guesses: {guess}");

                char feedback = UserFeedbackFun();
                Check = FeedbackFun(feedback, ref low, ref high, guess);
            }

            Console.WriteLine("Computer guessed your number correctly!");
        }
        static int RandomGuessFun(Random random, int low, int high)
        {
            return random.Next(low, high + 1);
        }

        static char UserFeedbackFun()
        {
            Console.Write("Enter feedback (h/l/c): ");
            return char.ToLower(Console.ReadKey().KeyChar);
        }

        static bool FeedbackFun(char feedback, ref int low, ref int high, int guess)
        {
            Console.WriteLine();

            switch (feedback)
            {
                case 'h':
                    high = guess - 1;
                    break;

                case 'l':
                    low = guess + 1;
                    break;

                case 'c':
                    return true;

                default:
                    Console.WriteLine("Invalid input! Use h, l, or c.");
                    break;
            }

            return false;
        }
    }
}
