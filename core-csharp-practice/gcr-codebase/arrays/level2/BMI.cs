using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.arrays.level2
{
    internal class BMI
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter number of persons : ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] heights = new double[n];
            double[] weights = new double[n];
            double[] BMI = new double[n];
            String[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the height and weight of {i + 1} person");

                Console.WriteLine("Enter the height : ");
                heights[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Enter the weight : ");
                weights[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculating BMI
            for (int i = 0; i < n; i++)
            {
                BMI[i] = weights[i] / (heights[i] * heights[i]);

                if (BMI[i] <= 18.4) status[i] = "Underweight";
                else if (BMI[i] <= 24.9) status[i] = "Normal";
                else if (BMI[i] <= 39.9) status[i] = "Overweight";
                else status[i] = "Obese";
            }

            // Displaying Output

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Person {i + 1} : Heights : {heights[i]} m , Weight : {weights[i]} kg , BMI : {BMI[i]} , Status : {status[i]}. ");
            }
        }
    }
}
