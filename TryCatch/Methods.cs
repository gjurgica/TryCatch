using CinemaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Methods
    {
        public void ChoseTheGenre(List<Movie> movie,string genreChoise)
        {
            if (genreChoise == "1")
            {
                var ComedyMovies = movie.Where(genre => genre.Genre == Genre.Comedy).ToList();
                Console.WriteLine("Your choise is:");
                foreach (var title in ComedyMovies)
                {
                    Console.WriteLine(title.Title);
                }
            }
            else if (genreChoise == "2")
            {
                var HorrorMovies = movie.Where(genre => genre.Genre == Genre.Horror).ToList();
                Console.WriteLine("Your choise is:");
                foreach (var title in HorrorMovies)
                {
                    Console.WriteLine(title.Title);
                }
            }
            else if (genreChoise == "3")
            {
                var ActionMovies = movie.Where(genre => genre.Genre == Genre.Action).ToList();
                Console.WriteLine("Your choise is:");
                foreach (var title in ActionMovies)
                {
                    Console.WriteLine(title.Title); 
                }
            }
            else if (genreChoise == "4")
            {
                var DramaMovies = movie.Where(genre => genre.Genre == Genre.Drama).ToList();
                Console.WriteLine("Your choise is:");
                foreach (var title in DramaMovies)
                {
                    Console.WriteLine(title.Title); 
                }
            }
            else
            {
                var SciFiMovies = movie.Where(genre =>  genre.Genre == Genre.SciFi).ToList();
                Console.WriteLine("Your choise is:");
                foreach (var title in SciFiMovies)
                {
                    Console.WriteLine(title.Title); 
                }
            }
        }
    }
}
