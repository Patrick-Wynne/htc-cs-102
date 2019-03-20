using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void AddMovieButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Movie movieToAdd = new Movie(titleInput.Text, Int32.Parse(releaseYearInput.Text));
                //string tryString = Convert.ToString(releaseYearInput.Text);
            }
            catch
            {
                MessageBox.Show("put in an int");
                titleInput.Clear();
                releaseYearInput.Clear();
                animationStudioInput.Clear();
                animationTypeInput.Clear();
                return;
            }

            //string adjusted = Convert.ToString(releaseYearInput);

            if (animationTypeInput.Text != "" || animationStudioInput.Text != "")
            {
                AnimatedMovie animatedMovieToAdd = new AnimatedMovie(titleInput.Text, Int32.Parse(releaseYearInput.Text), animationStudioInput.Text, animationTypeInput.Text);
                MovieList.Add(animatedMovieToAdd);
                animationStudioInput.Clear();
                animationTypeInput.Clear();
            }
            else
            {
                Movie movieToAdd = new Movie(titleInput.Text, Int32.Parse(releaseYearInput.Text));
                MovieList.Add(movieToAdd);

            }

            titleInput.Clear();
            releaseYearInput.Clear();

        }
    }
}
