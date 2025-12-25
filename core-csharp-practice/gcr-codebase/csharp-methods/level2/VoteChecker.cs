using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level2
{
    internal class VoteChecker
    {
        static void Main(String[] args)
        {
            // Taking Input
            Console.WriteLine("Enter the age of 10 Students : ");

            // Cresting Array 
            int[] age = new int[10];

            for (int i = 0; i < age.Length; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display Output
            foreach (int i in age)
            {
                bool votecheck = CanStudentVote(i);
                Console.WriteLine(votecheck ? "Can Vote" : "Can not Vote");
            }

        }

        static bool CanStudentVote(int age)
        {
            return age >= 18;
        }
    }
}
