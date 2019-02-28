using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        private string title;
        private string releaseYear;
        private string director;
        private string length;
        private string genre;

        public Movie(string title, string releaseYear, string director, string length, string genre)
        {
            this.title = title;
            this.releaseYear = releaseYear;
            this.director = director;
            this.length = length;
            this.genre = genre;
        }

        public void ShowMovie()
        {
            MessageBox.Show("Title: " + title + Environment.NewLine+ "Release Year: " + releaseYear + Environment.NewLine+ "Dierctor: " + director + Environment.NewLine+ "Length: " + length + Environment.NewLine+ "Genre: " + genre);
        }
    }
}
