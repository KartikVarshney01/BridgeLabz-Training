using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class MovieManagementSystem
    {
        static void Main(String[] args)
        {
            MovieDoublyLinkedList movies = new MovieDoublyLinkedList();

            movies.AddAtBeginning("KFG", "John", 2022, 9.5);
            movies.AddAtEnd("War", "Nolan", 2016, 8.6);
            movies.AddAtPosition(2, "Avatar", "James", 2009, 7.8);

            Console.WriteLine("Movies (Forward):");
            movies.DisplayForward();

            Console.WriteLine("Movies (Reverse):");
            movies.DisplayReverse();

            Console.WriteLine("Search by Director:");
            movies.SearchByDirector("John");

            Console.WriteLine("Update Rating:");
            movies.UpdateRating("Avatar", 8.1);

            Console.WriteLine("Remove Movie:");
            movies.RemoveByTitle("KFG");

            Console.WriteLine("Final Movie List:");
            movies.DisplayForward();
        }
    }

    // Class Movie that acts as node
    class Movie
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public Movie Prev;
        public Movie Next;

        public Movie(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Prev = null;
            Next = null;
        }
    }

    // Doubly Linked List class
    class MovieDoublyLinkedList
    {
        private Movie head;
        private Movie tail;

        // Add at beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);

            if (head == null)
            {
                head = tail = newMovie;
            }
            else
            {
                newMovie.Next = head;
                head.Prev = newMovie;
                head = newMovie;
            }
        }

        // Add at end
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            Movie newMovie = new Movie(title, director, year, rating);

            if (tail == null)
            {
                head = tail = newMovie;
            }
            else
            {
                tail.Next = newMovie;
                newMovie.Prev = tail;
                tail = newMovie;
            }
        }

        // Add at specific position
        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            Movie temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            Movie newMovie = new Movie(title, director, year, rating);
            newMovie.Next = temp.Next;
            newMovie.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = newMovie;
            else
                tail = newMovie;

            temp.Next = newMovie;
        }

        // Remove by Movie Title
        public void RemoveByTitle(string title)
        {
            Movie temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    if (temp == head)
                        head = temp.Next;
                    if (temp == tail)
                        tail = temp.Prev;

                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;

                    Console.WriteLine("Movie removed successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Search by Director
        public void SearchByDirector(string director)
        {
            Movie temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director.");
        }

        // Search by Rating
        public void SearchByRating(double rating)
        {
            Movie temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Rating >= rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating.");
        }

        // Update rating by title
        public void UpdateRating(string title, double newRating)
        {
            Movie temp = head;

            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movie records available.");
                return;
            }

            Movie temp = head;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("No movie records available.");
                return;
            }

            Movie temp = tail;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Prev;
            }
        }

        // Function To Display Movie
        private void DisplayMovie(Movie movie)
        {
            Console.WriteLine(
                $"Title: {movie.Title}, Director: {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating}"
            );
        }
    }
}
