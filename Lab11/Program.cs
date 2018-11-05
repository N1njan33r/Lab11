using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Movie movie = new 

            Console.ReadKey();
        }
        //public static int GetNumber()
        //{
        //    int number;
        //    bool parsed;
        //    do
        //    {
        //        var answer = Console.ReadLine();
        //        parsed = int.TryParse(answer, out number);
        //    } while (parsed == false);

        //    return number;
        //}
    }

    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
            var movies = MovieMaker.Create();
            foreach (var item in movies)
                Console.WriteLine(item.Title);
        }
        enum Categories { animated = 1, drama = 2, horror = 3, scifi = 4 }
        
    }
}
