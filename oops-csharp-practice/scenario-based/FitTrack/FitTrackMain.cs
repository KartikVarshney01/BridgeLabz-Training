using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    internal class FitTrackMain
    {
        /// <summary>
        /// The Program of Fit Tracker is used to help us in learning oops concept
        /// The program takes user data and duration of user workout and works on two types of workouts cardio and strength
        /// and then gives the amount of calorie burned in the workout.
        /// 
        /// version - 1.0
        /// </summary>
        static void Main(String[] args)
        {
            FitTrackMenu menu = new FitTrackMenu();
            menu.Start();
        }
    }
}
