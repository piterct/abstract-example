using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countOfMovies = 1;

            var movies = new List<Movie>();
            for (int i = 0; i < countOfMovies; i++)
            {


                movies.Add(new Movie
                {
                    Title = "The_Godfather",
                    Genre = "Action",
                    Rating = 96
                });
                movies.Add(new Movie
                {
                    Title = "The_Dark_Knight",
                    Genre = "Drama",
                    Rating = 24
                });
                movies.Add(new Movie
                {
                    Title = "Cleopatra",
                    Genre = "Comedy",
                    Rating = 61
                });
            }

            Console.WriteLine($"Highest rating is {HighestRating(movies)}");
            Console.WriteLine($"Lowest rating is {LowestRating(movies)}");
            Console.WriteLine($"Average rating is {AverageRating(movies)}");
            foreach (var mv in HighestRatingForEachGenre(movies))
            {
                Console.WriteLine($"The highest rating for genre {mv.Key} is {mv.Value.Rating}. Movie's title is {mv.Value.Title}");
            }
        }

        public static int HighestRating(List<Movie> movies)
        {
            return movies.Max(x => x.Rating);
        }

        public static int LowestRating(List<Movie> movies)
        {
            return movies.Min(x => x.Rating);
        }

        public static int AverageRating(List<Movie> movies)
        {
            return Convert.ToInt32(movies.Average(x => x.Rating));
        }

        public static Dictionary<string, Movie> HighestRatingForEachGenre(List<Movie> movies)
        {
            return movies.OrderByDescending(x => x.Rating).ToDictionary(x => x.Genre);
        }

        public class Movie
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public int Rating { get; set; }
        }
    }
}
