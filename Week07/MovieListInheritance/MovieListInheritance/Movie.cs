﻿using System.Text.RegularExpressions;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public void ShowDetails()
        {
            //string infoString = "Title: " + this.Title;
            //infoString += "\nRelease Year: " + this.ReleaseYear;
            //MessageBox.Show(infoString);
            string path = Regex.Replace(Title, " ", "_");
            System.Diagnostics.Process.Start("https://www.wikipedia.org/wiki/" + path);
        }

        public Movie() { }

        public Movie(string myTitle, int myReleaseYear)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }
    }
}
