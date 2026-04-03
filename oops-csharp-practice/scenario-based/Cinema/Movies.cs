using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Cinema
{
    // Movie class containig movie details 
    internal class Movies
    {
        public string movieTitle { get; set; }

        public TimeOnly showTime {  get; set; }

        public override string ToString()
        {
            return String.Format("{0} : {1}",movieTitle,showTime);
        }
    }
}
