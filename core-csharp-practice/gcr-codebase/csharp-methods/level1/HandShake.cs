using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    internal class HandShake
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.Write("Enter the number of students : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Calling function Find to calculate the handshake numbers.
            int combination = Find(num);

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
