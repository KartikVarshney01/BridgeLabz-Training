using System;
using System.Collections.Generic;   
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    // Derived Class Cardio Inherting WorkOut
    internal class CardioWorkout : Workout
    {
        public CardioWorkout(int duration) : base(duration) { }

        public override double CalorieBurned()
        {
            return DurationInMinutes * 9.0;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine("Tracking Cardio Workout");
        }
    }
}
