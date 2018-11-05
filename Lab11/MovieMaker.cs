using System.Collections.Generic;

namespace Lab11
{
    class MovieMaker
    {
        public static List<Movie> Create()
        {
            var result = new List<Movie>();

            result.Add(new Movie("Star Wars", "scifi"));
            result.Add(new Movie("Star Trek", "scifi"));
            result.Add(new Movie("Avatar", "scifi"));
            result.Add(new Movie("Flash Gordon", "scifi"));
            result.Add(new Movie("Battlestar Galactica", "scifi"));
            result.Add(new Movie("Obi Wan feat Ewan McGregor", "scifi"));

            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Friday the 13th", "horror"));


            return result;
        }
    }
}
