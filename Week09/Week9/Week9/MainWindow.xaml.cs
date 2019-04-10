using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Input;

namespace Week9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myEllipseGeometry = new EllipseGeometry();
            myEllipseGeometry.Center = new Point(200, 200);
            myEllipseGeometry.RadiusX = 20;
            myEllipseGeometry.RadiusY = 20;

            Path myPath = new Path();
            myPath.Fill = Brushes.SkyBlue;
            myPath.Data = myEllipseGeometry;

            myCanvas.Children.Add(myPath);
            
        }
        EllipseGeometry myEllipseGeometry;
        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
                PointAnimation myPointAnimation = new PointAnimation(e.GetPosition(this), TimeSpan.FromSeconds(1));
                myPointAnimation.EasingFunction = new ElasticEase();
                myEllipseGeometry.BeginAnimation(EllipseGeometry.CenterProperty, myPointAnimation);
        }
    }
}
