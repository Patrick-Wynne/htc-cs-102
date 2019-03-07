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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }

            List<Duck> ducks = new List<Duck> ();

            Duck duck1 = new Duck(25, "Harry");
            Duck duck2 = new Duck(45, "Henrietta");

            ducks.Add(duck1);
            ducks.Add(duck2);

            foreach (Duck d in ducks)
            {
                d.SayName();
            }

            List<Frog> frogs = new List<Frog>();

            Frog frog1 = new Frog(25, "Croak", true);
            Frog frog2 = new Frog(45, "Pepe", false);

            frogs.Add(frog1);
            frogs.Add(frog2);

            foreach (Frog f in frogs)
            {
                f.SayName();
            }

            List<Cow> cows = new List<Cow>();

            Cow cow1 = new Cow(25, "Lennard", "brown");
            Cow cow2 = new Cow(45, "Harold", "white");

            cows.Add(cow1);
            cows.Add(cow2);

            foreach (Cow c in cows)
            {
                c.SayName();
            }

        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void Moo_Button_Click(object sender, RoutedEventArgs e)
        {
            Cow cow = new Cow();
            cow.Moo();
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            Organism org = new Organism();
            MessageBox.Show(org.ToString());
        }
    }
}
