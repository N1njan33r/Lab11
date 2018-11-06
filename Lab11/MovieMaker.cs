using System.Collections.Generic;

namespace Lab11
{
    class MovieMaker
    {
        public static List<Movie> Create()
        {
            // James - I really like this static method, cool stuff.
            var result = new List<Movie>();

            // scifi
            result.Add(new Movie("Star Wars", "scifi"));
            result.Add(new Movie("Star Trek", "scifi"));
            result.Add(new Movie("Avatar", "scifi"));
            result.Add(new Movie("Flash Gordon", "scifi"));
            result.Add(new Movie("Battlestar Galactica", "scifi"));
            result.Add(new Movie("Obi Wan feat Ewan McGregor", "scifi"));

            // horror
            result.Add(new Movie("Friday the 13th", "horror"));
            result.Add(new Movie("Nightmare on Elm Street", "horror"));
            result.Add(new Movie("IT", "horror"));
            result.Add(new Movie("The Omen", "horror"));
            result.Add(new Movie("House on Haunted Hill", "horror"));
            result.Add(new Movie("Halloween", "horror"));

            // animated
            result.Add(new Movie("Spirited Away", "animated"));
            result.Add(new Movie("Naussica", "animated"));
            result.Add(new Movie("My Neighbor, Totoro", "animated"));
            result.Add(new Movie("Kiki's Delivery Service", "animated"));
            result.Add(new Movie("Princess Mononoke", "animated"));
            result.Add(new Movie("Castle in the Sky", "animated"));
            
            // drama
            result.Add(new Movie("My Big Fat Greek Wedding", "drama"));
            result.Add(new Movie("Valentine's Day", "drama"));
            result.Add(new Movie("The Greatest Showman", "drama"));
            result.Add(new Movie("Adrift", "drama"));
            result.Add(new Movie("The Godfather", "drama"));
            result.Add(new Movie("Pulp Fiction", "drama"));
            
            return result;
        }
    }
}
