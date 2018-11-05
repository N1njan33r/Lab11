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
            var movies = MovieMaker.Create();
            Console.WriteLine("There are {0} movies in the list", movies.Count);
            do
            {
                Console.Write("Please select a category (scifi, horror, drama, animated): ");
                string userInput = Console.ReadLine();
                foreach (var item in movies)
                    if (item.Category == userInput)
                        Console.WriteLine(item.Title);
                Console.Write("Try again? (y/n): ");
                ConsoleKeyInfo repeat = Console.ReadKey();
                Console.WriteLine();
                if (!repeat.KeyChar.Equals('y'))
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Thank you!");
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
}
