using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.FitTrack
{
    // Workout Class containing workout methods
    abstract class Workout : ITrackable
    {
        public int DurationInMinutes { get; set; }

        public Workout(int duration)
        {
            DurationInMinutes = duration;
        }

        public abstract double CalorieBurned();

        public virtual void TrackWorkout()
        {
            Console.WriteLine("Tracking workout...");
        }
    }
}
