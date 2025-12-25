using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class HandShake2
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number of students : ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Calling function Find to calculate the handshake numbers.
            int combination = Find(numberOfStudents);

            // Display Output
            Console.WriteLine($"The maximum number of handshakes are : {combination}");
        }

        static int Find(int num)
        {
            int ans = (num * (num - 1)) / 2;
            return ans;
        }
    }
}


