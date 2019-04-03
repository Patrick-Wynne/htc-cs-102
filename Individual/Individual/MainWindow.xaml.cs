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

namespace Individual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Rectangle myRect = new Rectangle();
            //myRect.Height = 100;
            //myRect.Width = 100;
            //myRect.Fill = Brushes.Red;
            //myRect.Stroke = Brushes.Black;
            //myRect.StrokeThickness = 2;
            //Canvas.SetLeft(myRect, 100);
            //Canvas.SetTop(myRect, 100);
            //myCanvas.Children.Add(myRect);

            //Diamond myDiam = new Diamond(Brushes.Black, Brushes.Red, 2, 100, 100);
            //myCanvas.Children.Add(myDiam);

            //Triangle myTri = new Triangle(Brushes.Black, Brushes.Red, 2, 100, 100, false);
            //myCanvas.Children.Add(myTri);

            Pentagon myPent = new Pentagon(Brushes.Black, Brushes.Red, 2, 100, 90);
            myCanvas.Children.Add(myPent);
        }
    }
}
