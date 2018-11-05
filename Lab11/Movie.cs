using System;

namespace Lab11
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        enum Categories { animated = 1, drama = 2, horror = 3, scifi = 4 }
        
    }
}
