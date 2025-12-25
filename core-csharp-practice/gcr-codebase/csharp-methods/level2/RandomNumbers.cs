using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class RandomNumbers
    {
        static void Main(String[] args)
        {
            int size = 5;

            // Creating random number array
            int[] numbers = RandomArrayFun(size);
            double[] result = AvgMinMaxFun(numbers);

            // Display Output 
            Console.WriteLine("Generated 4-digit numbers:");
            foreach (int n in numbers) Console.Write(n + " ");

            Console.WriteLine($"\nAverage : {result[0]:F2}");
            Console.WriteLine($"Minimum : {result[1]}");
            Console.WriteLine($"Maximum : {result[2]}");
        }

        static int[] RandomArrayFun(int size)
        {
            int[] arr = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1000, 10000);
            }

            return arr;
        }

        static double[] AvgMinMaxFun(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }
    }
}
