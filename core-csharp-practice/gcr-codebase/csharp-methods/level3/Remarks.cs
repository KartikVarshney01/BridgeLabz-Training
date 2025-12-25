using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Remarks
    {
        static void Main(String[] args)
        {
            // Taking input for number of students
            Console.Write("Enter number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());

            // Calling functions to find the scores and results
            int[,] scores = ScoresFun(students);
            double[,] results = ResultsFun(scores);

            Display(scores, results);
        }

        static int[,] ScoresFun(int students)
        {
            int[,] scores = new int[students, 3];
            Random random = new Random();

            for (int i = 0; i < students; i++)
            {
                scores[i, 0] = random.Next(10, 100); // Physics
                scores[i, 1] = random.Next(10, 100); // Chemistry
                scores[i, 2] = random.Next(10, 100); // Maths
            }

            return scores;
        }

        static double[,] ResultsFun(int[,] scores)
        {
            int students = scores.GetLength(0);
            double[,] results = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3.0;
                double percentage = (total / 300.0) * 100;

                results[i, 0] = total;
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }

            return results;
        }
        static void Display(int[,] scores, double[,] results)
        {
            Console.WriteLine("\nScore Card");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            Console.WriteLine("--------------------------------------------------------------");

            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    scores[i, 0] + "\t" +
                    scores[i, 1] + "\t\t" +
                    scores[i, 2] + "\t" +
                    results[i, 0] + "\t" +
                    results[i, 1] + "\t" +
                    results[i, 2]
                );
            }
        }
    }
}
