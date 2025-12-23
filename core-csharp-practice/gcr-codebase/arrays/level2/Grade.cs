using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class Grade
    {
        static void Main()
        {
            // Taking input
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Initializing 1-D arrays
            int[] physics = new int[n];
            int[] chemistry = new int[n];
            int[] maths = new int[n];
            double[] percent = new double[n];
            char[] grade = new char[n];

            // Taking user input
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter marks for student {i + 1}:");

                Console.Write("Enter Physics marks: ");
                int phy = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Chemistry marks: ");
                int chem = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Maths marks: ");
                int math = Convert.ToInt32(Console.ReadLine());

                if (phy < 0 || chem < 0 || math < 0)
                {
                    Console.WriteLine("Invalid marks! Enter positive values.");
                    i--;
                    continue;
                }

                physics[i] = phy;
                chemistry[i] = chem;
                maths[i] = math;
            }

            // Calculating percentage and grade
            for (int i = 0; i < n; i++)
            {
                int total = physics[i] + chemistry[i] + maths[i];
                percent[i] = total / 3.0;

                if (percent[i] >= 80) grade[i] = 'A';
                else if (percent[i] >= 70) grade[i] = 'B';
                else if (percent[i] >= 60) grade[i] = 'C';
                else if (percent[i] >= 50) grade[i] = 'D';
                else if (percent[i] >= 40) grade[i] = 'E';
                else grade[i] = 'R';
            }

            // Display Output
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    $"Physics: {physics[i]}  Chemistry: {chemistry[i]}  Maths: {maths[i]}  Percentage: {percent[i]:F2}%  Grade: {grade[i]}"
                );
            }
        }
    }
}
