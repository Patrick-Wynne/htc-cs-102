using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title;
        public string ReleaseYear;

        public Movie(string title, string releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }
    }
}
