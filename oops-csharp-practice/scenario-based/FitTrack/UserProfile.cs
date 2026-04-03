using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    // User Profile Class containing all the user related data and encapsulated
    internal class UserProfile
    {
        // Creating User data variables
        public int userId { get; set; }
        public string userName { get; set; }
        public int userAge { get; set; }

        public double userHeight { get; set; }

        public double userWeight { get; set; }

        public UserProfile(int userId, string userName, int userAge, double userHeight, double userWeight)
        {
            this.userId = userId;
            this.userName = userName;
            this.userAge = userAge;
            this.userHeight = userHeight;
            this.userWeight = userWeight;
        }

        //public override string ToString()
        //{
        //    return $"ID : {userId} || Name : {userName} || Age : {userAge} || Height : {userHeight} || Weight : {userWeight}";
        //}

        public void DisplayUser()
        {
            Console.WriteLine("\n--- User Profile ---");
            Console.WriteLine($"ID     : {userId}");
            Console.WriteLine($"Name   : {userName}");
            Console.WriteLine($"Age    : {userAge}");
            Console.WriteLine($"Height : {userHeight} cm");
            Console.WriteLine($"Weight : {userWeight} kg");
        }
    }
}
