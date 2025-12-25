using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class BMI
    {
        static void Main()
        {
            // Creating data array with 10 rows (persons), 3 columns (weight, height, bmi)
            double[,] data = new double[10, 3];

            // Taking Input
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Person {i + 1} : ");

                Console.Write("Weight (kg): ");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height (cm): ");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculating BMI
            CalculateBMI(data);

            // Finding Status
            string[] status = BMIStatus(data);

            // Display output
            Console.WriteLine("Height,Weight,BMI,Status Details are : ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Height : {data[i, 1]:F2}, Weight : {data[i, 0]:F2}, BMI : {data[i, 2]:F2}, Status : {status[i]}");
            }
        }
        static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < 10; i++)
            {
                double height = data[i, 1] / 100;
                data[i, 2] = data[i, 0] / (height * height);
            }
        }
        static string[] BMIStatus(double[,] data)
        {
            string[] status = new string[10];

            for (int i = 0; i < 10; i++)
            {
                double bmi = data[i, 2];

                if (bmi <= 18.4)
                    status[i] = "Underweight";
                else if (bmi <= 24.9)
                    status[i] = "Normal";
                else if (bmi <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            return status;
        }
    }
}
