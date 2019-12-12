using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MongoMovieDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {

            var movieRepository = new MovieRepository(@"mongodb://posey:oitcst324@ds259305.mlab.com:59305/oitcst324");

            var movies = movieRepository.GetAllMovies();            

            // LINQ query on local set (movies)

            Console.WriteLine("List all of movies that were released in Canada:\n");
            // Q1: query to display all of movies that were released in Canada.
            List<Movie> canadian_movies = movies.Where(x => x.Country == "Canada").ToList();

            for (int i = 0; i < canadian_movies.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + "\t" + canadian_movies[i].MovieTitle.ToString());
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();

            // Q2: query to display how many movies had an imdb_score of greater than 9.
            int imdb_gt_9 = movies.Where(x => x.ImdbScore > 9).Count();

            Console.WriteLine("Number of how many movies had an imdb_score of greater than 9: " + imdb_gt_9.ToString() + "\n\n");

            Console.ReadKey();

            Console.WriteLine("List all of movies with Natalie Portman as an actor:\n");
            // Q3: query to list the movies starring Natalie Portman as actor_1_name, actor_2_name, or
            // actor_3_name.
            List<Movie> natatalie_portman = movies.Where(x => (x.Actor1Name == "Natalie Portman" ||
                                                               x.Actor2Name == "Natalie Portman" ||
                                                               x.Actor3Name == "Natalie Portman")).ToList();

            for (int i = 0; i < natatalie_portman.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + "\t" + natatalie_portman[i].MovieTitle.ToString());
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();

            Console.WriteLine("List all of movies with Clint Eastwood as an actor or director:\n");
            // Q4: query to list the movies either starring(actor_1_name, actor_2_name, actor_3_name)
            // or directed by(director_name) Clint Eastwood.
            List<Movie> clint_eastwood = movies.Where(x => (x.DirectorName == "Clint Eastwood" ||
                                                            x.Actor1Name == "Clint Eastwood" ||
                                                            x.Actor2Name == "Clint Eastwood" ||
                                                            x.Actor3Name == "Clint Eastwood")).ToList();

            for (int i = 0; i < clint_eastwood.Count(); i++)
            {
                Console.WriteLine((i + 1).ToString() + "\t" + clint_eastwood[i].MovieTitle.ToString());
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();

            // Q5: query to list the number of movies in the Drama genre (genres).
            int num_drama_movies = movies.Where(x => x.Genres == "Drama").Count();

            Console.WriteLine("Number of movies within the drama genre: " + num_drama_movies.ToString());

            Console.ReadKey();
        }
    }
}
