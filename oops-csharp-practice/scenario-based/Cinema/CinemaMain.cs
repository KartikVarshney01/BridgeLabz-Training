using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Cinema
{
    /// <summary>
    /// The program of Cinema Time is a program that is used to help in addind a movie, searching a movie by keyword and to display all movies
    ///
    /// version - 1.0
    /// </summary>
    internal class CinemaMain
    {
        static void Main(string[] args)
        {
            CinemaMenu start = new CinemaMenu();
            start.Menu();
        }
    }
}
