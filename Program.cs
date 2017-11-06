using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        public static void Main(string[] args)
        {
            var movies = new List<Movies>
            {
                new Movies {Title= "The Dark Knight Rises", Rating= 8.9f, Year=2007 },
                new Movies {Title="The Immortals", Rating=7.6f, Year=1942 },
                new Movies {Title="Schindlers List",Rating=8.9f, Year=1993 },
                new Movies {Title="The Pianist",Rating=8.5f, Year=2002 }
            };



            //using extension method

            var query = movies.Filter(m => m.Year > 2000);

            foreach (var item in query)
            {
                Console.WriteLine(item.Title);
            }
            Console.ReadLine();
        }
    }
}
