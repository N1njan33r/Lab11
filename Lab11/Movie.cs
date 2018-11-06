using System;

namespace Lab11
{
    // James - awesome class, I like that you are using auto properties here, good stuff.
    class Movie
    {
        public string Title { get; set; }

        // James - just so you know, you can make this property your enum, so it would look something like.
        // 
        // public Categories Category { get; set; }
        public string Category { get; set; }
        
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        enum Categories { animated = 1, drama = 2, horror = 3, scifi = 4 }
        
    }
}
