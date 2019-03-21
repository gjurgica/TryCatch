using CinemaClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Methods GenreChoise = new Methods();
            GenerateMovies MoviesLists = new GenerateMovies();
            Cinema Cineplex = new Cinema();
            Cineplex.Name = "Cineplex";
            Cineplex.Halls = new List<int>{ 1,2,3,4};
            Cineplex.Movies = MoviesLists.FirstList();
            Cinema Milenium = new Cinema();
            Milenium.Name = "Milenium";
            Milenium.Halls = new List<int> { 1, 2 };
            Milenium.Movies = MoviesLists.SecondList();

            Console.WriteLine("Choose the Cinema.\nYour choise is:\n1.Cineplex\n2.Milenium");
            string chosenCinema = Console.ReadLine();
            try
            {
                if(chosenCinema == "1")
                {
                    Console.WriteLine("Choose your list:\n1.All movies\n2.Sorted by genre.");
                    string allOrGenre = Console.ReadLine();
                    try
                    {
                        if(allOrGenre == "1")
                        {
                            Console.WriteLine("Your list is:");
                            foreach(var movie in Cineplex.Movies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("Chose the movie");
                            string movieToPlay = Console.ReadLine();
                            try
                            {
                                foreach(var movie in Cineplex.Movies)
                                {
                                    if(movieToPlay.ToLower() == movie.Title.ToLower())
                                    {
                                        Cineplex.MoviePlaying(movie);
                                        break;
                                    }
                                    else
                                    {
                                        throw new Exception("Please enter a movie title from the list");
                                    }
                                }

                            }catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else if(allOrGenre == "2")
                        {
                            try
                            {
                                Console.WriteLine("Your choise is:\n1.Comedy\n2.Horror\n3.Action\n4.Drama\n5.SciFi");
                                string genreChoise = Console.ReadLine();
                                if(genreChoise == "1" || genreChoise == "2" || genreChoise == "3" || genreChoise == "4" || genreChoise == "5")
                                {
                                    GenreChoise.ChoseTheGenre(MoviesLists.FirstList(), genreChoise);
                                }
                                else
                                {
                                    throw new Exception("Please enter number from 1 to 5");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            throw new Exception("Please choose 1 or 2");
                        }

                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else if(chosenCinema == "2")
                {
                    Console.WriteLine("Choose your list:\n1.All movies\n2.Sorted by genre.");
                    string allOrGenre = Console.ReadLine();
                    try
                    {
                        if(allOrGenre == "1")
                        {
                            Console.WriteLine("Your list is:");
                            foreach (var movie in Milenium.Movies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("Chose the movie");
                            string movieToPlay = Console.ReadLine();
                            try
                            {
                                foreach(var movie in Milenium.Movies)
                                {
                                    if(movieToPlay.ToLower() == movie.Title.ToLower())
                                    {
                                        Milenium.MoviePlaying(movie);
                                        break;
                                    }
                                    else
                                    {
                                        throw new Exception("Please enter a movie title from the list");
                                    }
                                }

                            }catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else if(allOrGenre == "2")
                        {
                            try
                            {
                                Console.WriteLine("Your choise is:\n1.Comedy\n2.Horror\n3.Action\n4.Drama\n5.SciFi");
                                string genreChoise = Console.ReadLine();
                                if (genreChoise == "1" || genreChoise == "2" || genreChoise == "3" || genreChoise == "4" || genreChoise == "5")
                                {
                                    GenreChoise.ChoseTheGenre(MoviesLists.SecondList(), genreChoise);
                                }
                                else
                                {
                                    throw new Exception("Please enter number from 1 to 5");
                                }
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else
                        {
                            throw new Exception("Please choose 1 or 2");
                        }

                    }catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    throw new Exception("Valid choise is 1 or 2");
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
       
            Console.ReadLine();

        }

    }
}
