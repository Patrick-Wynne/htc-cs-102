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

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Triangle myTri = new Triangle(Brushes.Black, Brushes.Red, 2, 100, 100);
            mainCanvas.Children.Add(myTri);
            comboBoxShapeSelect.SelectedIndex = 1;
            comboBoxTypeSelect.SelectedIndex = 0;
        }

        private void comboBoxTypeSelect_SelectionChanged(object sender, EventArgs e)
        {
                var select = comboBoxTypeSelect.SelectedIndex.ToString();

                if (select == "0")
                {
                    Brush shapeColor = Brushes.Red;
                    displayShape(shapeColor);
                }
                else if (select == "1")
                {
                    Brush shapeColor = Brushes.Blue;
                    displayShape(shapeColor);
                }
                else if (select == "2")
                {
                    Brush shapeColor = Brushes.Yellow;
                    displayShape(shapeColor);
                }
        }

        private void comboBoxShapeSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBoxTypeSelect_SelectionChanged(sender, e);
        }
        private void displayShape(Brush color)
        {
            var select = comboBoxShapeSelect.SelectedIndex.ToString();

            if (select == "0")
            {
                mainCanvas.Children.Clear();
                Rectangle myRect = new Rectangle();
                myRect.Height = 50;
                myRect.Width = 50;
                myRect.Fill = color;
                myRect.Stroke = Brushes.Black;
                myRect.StrokeThickness = 2;
                mainCanvas.Children.Add(myRect);
            }
            else if (select == "1")
            {
                mainCanvas.Children.Clear();
                Triangle myTri = new Triangle(Brushes.Black, color, 2, 50, 50);
                mainCanvas.Children.Add(myTri);
            }
            else if (select == "2")
            {
                mainCanvas.Children.Clear();
                Circle myCir = new Circle(Brushes.Black, color, 2, 50, 50);
                mainCanvas.Children.Add(myCir);
            }
        }
        private void addSquare(Brush color)
        {
            Rectangle myRect = new Rectangle();
            myRect.Height = 50;
            myRect.Width = 50;
            myRect.Fill = Brushes.Red;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;
            mainCanvas.Children.Add(myRect);
        }
        private void addTriangle(Brush color)
        {
            Triangle myTri = new Triangle(Brushes.Black, Brushes.Red, 2, 50, 50);
            mainCanvas.Children.Add(myTri);
        }
        private void addCircle(Brush color)
        {
            Circle myCir = new Circle(Brushes.Black, Brushes.Red, 2, 50, 50);
            mainCanvas.Children.Add(myCir);
        }
    }
}
