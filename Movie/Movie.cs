using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClasses
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }
        public Movie(string title,Genre genre,int rating)
        {
            Title = title;
            Genre = genre;
            try
            {
                if(rating > 0 && rating < 6)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Rating must be between 1 and 5");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            TicketPrice = 5 * rating;
        }
    }
}
