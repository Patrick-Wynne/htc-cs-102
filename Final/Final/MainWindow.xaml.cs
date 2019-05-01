using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
                //info.Content = "hp:200\nattack:30";
                //playerHealth.Maximum = 200;
                //playerHealth.Value = 200;
            }
            else if (select == "1")
            {
                mainCanvas.Children.Clear();
                Triangle myTri = new Triangle(Brushes.Black, color, 2, 50, 50);
                mainCanvas.Children.Add(myTri);
                //info.Content = "hp:150\nattack:45";
                //playerHealth.Maximum = 150;
                //playerHealth.Value = 150;
            }
            else if (select == "2")
            {
                mainCanvas.Children.Clear();
                Circle myCir = new Circle(Brushes.Black, color, 2, 50, 50);
                mainCanvas.Children.Add(myCir);
                //info.Content = "hp:100\nattack:60";
            }
        }
        private void addSquare(Brush color)
        {
            Rectangle myRect = new Rectangle();
            myRect.Height = 50;
            myRect.Width = 50;
            myRect.Fill = color;
            myRect.Stroke = Brushes.Black;
            myRect.StrokeThickness = 2;
            enemyCanvas.Children.Add(myRect);
        }
        private void addTriangle(Brush color)
        {
            Triangle myTri = new Triangle(Brushes.Black, color, 2, 50, 50);
            enemyCanvas.Children.Add(myTri);
        }
        private void addCircle(Brush color)
        {
            Circle myCir = new Circle(Brushes.Black, color, 2, 50, 50);
            enemyCanvas.Children.Add(myCir);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clearCanv.Children.Clear();
            Random shapeColor = new Random();
            switch (shapeColor.Next(1, 9))
            {
                case 1:
                    addSquare(Brushes.Red);
                    //enemyHealth.Maximum = 200;
                    //enemyHealth.Value = 200;
                    break;
                case 2:
                    addSquare(Brushes.Blue);
                    //enemyHealth.Maximum = 200;
                    //enemyHealth.Value = 200;
                    break;
                case 3:
                    addSquare(Brushes.Yellow);
                    //enemyHealth.Maximum = 200;
                    //enemyHealth.Value = 200;
                    break;
                case 4:
                    addCircle(Brushes.Red);
                    //enemyHealth.Maximum = 100;
                    //enemyHealth.Value = 100;
                    break;
                case 5:
                    addCircle(Brushes.Blue);
                    //enemyHealth.Maximum = 100;
                    //enemyHealth.Value = 100;
                    break;
                case 6:
                    addCircle(Brushes.Yellow);
                    //enemyHealth.Maximum = 100;
                    //enemyHealth.Value = 100;
                    break;
                case 7:
                    addTriangle(Brushes.Blue);
                    //enemyHealth.Maximum = 150;
                    //enemyHealth.Value = 150;
                    break;
                case 8:
                    addTriangle(Brushes.Yellow);
                    //enemyHealth.Maximum = 150;
                    //enemyHealth.Value = 150;
                    break;
                default:
                    addTriangle(Brushes.Red);
                    //enemyHealth.Maximum = 150;
                    //enemyHealth.Value = 150;
                    break;
            }
            fightCanv.Visibility = Visibility.Visible;
        }

        private void fightButton_Click(object sender, RoutedEventArgs e)
        {
            fightButton.Visibility = Visibility.Hidden;
            fightButton.IsEnabled = false;
            selections.Visibility = Visibility.Visible;
            selections.IsEnabled = true;
        }

        private void quickAttack_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("used quick attack");
            enemyHealth.Value -= 10;
            if (enemyHealth.Value <= 0)
            {
                endScreen(true);
                return;
            }
            enemyAttack();
        }
    }
        public int specialUses = 2;
        private void special_Click(object sender, RoutedEventArgs e)
        {
            if (specialUses > 1)
            {
                specialUses--;
                MessageBox.Show("used special ("+specialUses+" Uses left)");
                enemyHealth.Value -= 30;
                if (enemyHealth.Value <= 0)
                {
                    endScreen(true);
                    return;
                }
            }
            else
            {
                specialUses--;
                MessageBox.Show("used special (" + specialUses + " Uses left)");
                enemyHealth.Value -= 30;
                if (enemyHealth.Value <= 0)
                {
                    endScreen(true);
                    return;
                }
                special.IsEnabled = false;
            }

            enemyAttack();
            enemyAttack();
        }

        public void enemyAttack()
        {
            Random rand = new Random();
            if (rand.Next(1, 10) >= 3 && rand.Next(1, 10) <= 8)
            {
                MessageBox.Show("Enemy used quick attack");
                playerHealth.Value -= 10;
            }
            else if(rand.Next(1, 10) <= 3)
            {
                MessageBox.Show("Enemy used Special Attack");
                playerHealth.Value -= 30;

            } else
            {
                MessageBox.Show("Enemy used Heal");
                enemyHealth.Value += 20;
            }
            if(playerHealth.Value<= 0)
            {
                endScreen(false);
            }
        }

        public void endScreen(bool won)
        {
            if (won == true)
            {
                endText.Content = "You Win!";
            }
            else
            {
                endText.Content = "You Loose!";
            }
            enemyCanvas.Visibility = Visibility.Hidden;
            mainCanvas.Visibility = Visibility.Hidden;
            fightCanv.Visibility = Visibility.Hidden;
            endText.Visibility = Visibility.Visible;
            playAgain.Visibility = Visibility.Visible;
        }
        public int uses = 2;
        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            if (uses > 1) {
                uses--;
                MessageBox.Show("used heal (" + uses + " uses left)");
                playerHealth.Value += 20;
            } else
            {
                uses--;
                MessageBox.Show("used heal (" + uses + " uses left)");
                playerHealth.Value += 20;
                heal.IsEnabled = false;
            }
            enemyAttack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
