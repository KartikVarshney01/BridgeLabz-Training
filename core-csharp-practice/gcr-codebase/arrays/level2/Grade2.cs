using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class Grade
    {
        static void Main()
        {
            // Taking Input
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // [][0]=Physics, [][1]=Chemistry, [][2]=Maths
            // Creating Arrays
            int[,] marks = new int[n, 3];
            double[] percent = new double[n];
            char[] grade = new char[n];

            // Taking user input
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter marks for student {i + 1}:");

                Console.Write("Enter chemistry mark : ");
                int chem = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter physics mark : ");
                int phy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter math mark : ");
                int math = Convert.ToInt32(Console.ReadLine());

                if (chem < 0 || phy < 0 || math < 0)
                {
                    Console.WriteLine("Invalid marks! Enter positive values.");
                    i--;
                    continue;
                }

                marks[i, 0] = phy;
                marks[i, 1] = chem;
                marks[i, 2] = math;
            }

            // Claculating percentange
            for (int i = 0; i < n; i++)
            {
                int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
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
                Console.WriteLine($"Physics: {marks[i, 0]}  Chemistry: {marks[i, 1]}  Maths: {marks[i, 2]}  Percentage: {percent[i]:F2}%  Grade: {grade[i]}");
            }
        }
    }
}
