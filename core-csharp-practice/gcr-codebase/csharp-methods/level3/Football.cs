using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Football
    {
        static void Main(String[] args)
        {
            // Creating an height array and putting random value of heights.
            int[] heights = new int[11];
            Random random = new Random();

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251);
            }

            // Calling functions to find sum,mean,shortest and tallest among them.
            int sum = SumFun(heights);
            int shortest = ShortestFun(heights);
            int tallest = TallestFun(heights);
            double mean = MeanFun(sum, heights.Length);

            // Display Output
            Console.WriteLine("The details of football team of shortest, tallest and mean height is : ");
            Console.WriteLine($"The Shortest height : {shortest}\n" +
                $"The Tallest Height : {tallest}\n" +
                $"The Mean Height : {mean}");

        }

        static int SumFun(int[] heights)
        {
            int sum = 0;
            foreach (int i in heights)
            {
                sum += i;
            }
            return sum;
        }

        static int ShortestFun(int[] heights)
        {
            int shortest = heights[0];
            foreach (int i in heights)
            {
                if (i < shortest) shortest = i;
            }
            return shortest;
        }

        static int TallestFun(int[] heights)
        {
            int tallest = 0;
            foreach (int i in heights)
            {
                if (i > tallest) tallest = i;
            }
            return tallest;
        }

        static double MeanFun(int sum, int num)
        {
            return (double)(sum / num);
        }
    }
}
