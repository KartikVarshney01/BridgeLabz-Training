using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    // Derived Class Strength 
    internal class StrengthWorkout : Workout
    {
        public StrengthWorkout(int duration) : base(duration) { }

        public override double CalorieBurned()
        {
            return DurationInMinutes * 7.0;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine("Tracking Strength Workout");
        }
    }
}
