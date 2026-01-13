using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.Cinema
{
    // Cinema Utility Class that contains all the interface funtions of adding, displaying and searching a movie.
    internal class CinemaUtilityImpl : ICinema
    {
        // Creating a Movie Array to store movies
        Movies[] moviesList;
        // Index Variable to iterate through the movies array
        int Idx = 0;

        // Add movie Function to create initialize the movie array and create and add new movie in it.
        public void AddMovie()
        {
            // Initializing the movie array. Checking if the movie array is empty or not. if it is empty then take size input from user and
            // initialize it.
            if (moviesList == null)
            {
                Console.Write("Enter the number of movies your cinema can have : ");
                int size = Convert.ToInt32(Console.ReadLine());

                moviesList = new Movies[size];
            }
            // Checking if there is capacity in the array to store new movie
            if (Idx >= moviesList.Length)
            {
                Console.WriteLine("Movies List Capacity is currently Full");
                return;
            }

            // Taking user input for the movie
            Console.Write("Enter The Movie Title : ");
            string title = Console.ReadLine();
            Console.Write("Enter the show Time : ");
            string time = Console.ReadLine();

            // Converting string time into DateTime/TimeOnly time format
            TimeOnly showTime = TimeOnly.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);

            // Creating a movie object and adding it to array
            Movies newMovie = new Movies();
            newMovie.movieTitle = title;
            newMovie.showTime = showTime;

            moviesList[Idx++] = newMovie;
            Console.WriteLine("Movie Added Successfully");
        }

        // Function to display a single movie
        public void DisplayMovie(Movies movie)
        {
            Console.WriteLine(movie);
        }

        // Function to Search a Movie by a keyword
        public void SearchMovie()
        {
            // Checking if there is the movie array is empty or not before search
            if(moviesList == null)
            {
                Console.WriteLine("No Movie Found. Add A Movie First");
                return;
            }

            // User input for the keyword
            Console.WriteLine("Search Any Movie : ");
            Console.Write("Enter the title or keyword : ");
            string keyword = Console.ReadLine();
            bool isFound = false;

            // Using for loop to iterate through the movie array
            for(int i = 0;i<Idx;i++)
            {
                if (moviesList[i].movieTitle.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayMovie(moviesList[i]);
                    isFound = true;
                }
            }
            // if no movie with keyword found
            if (!isFound) Console.WriteLine("No Movies With the keyword is found.");
        }

        // Function to display all movies
        public void DisplayAllMovies()
        {
            if (moviesList == null)
            {
                Console.WriteLine("No Movie Found. Add A Movie First");
                return;
            }
            for (int i = 0; i<Idx;i++)
            {
                Console.WriteLine(moviesList[i]);
            }
        }
    }
}
