using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class SimpleInterest
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the principle amount : ");
            int principle = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the rate of Interest : ");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the time : ");
            int time = Convert.ToInt32(Console.ReadLine());

            //Calling function Interest to find the simple interest
            int si = Interest(principle, rate, time);

            // Display Output
            Console.WriteLine($"The Simple Interest is {si} for Principal {principle}, Rate of Interest {rate} and Time {time}.");
        }
        static int Interest(int principle, int rate, int time)
        {
            int simpleIn = (principle * rate * time) / 100;
            return simpleIn;
        }
    }
}
