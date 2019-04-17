using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Final
{
    class Circle : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                EllipseGeometry myEllipseGeometry = new EllipseGeometry();
                myEllipseGeometry.Center = new Point(200, 200);
                myEllipseGeometry.RadiusX = Width/2;
                myEllipseGeometry.RadiusY = Height/2;

                Path myPath = new Path();
                myPath.Fill = Fill;
                myPath.Stroke = Stroke;
                myPath.StrokeThickness = StrokeThickness;
                myPath.Data = myEllipseGeometry;

                return myEllipseGeometry;
            }
        }
        public Circle(Brush strokeColor, Brush fillColor, double strokeThickness, int width, int height)
        {
            this.Stroke = strokeColor;
            this.Fill = fillColor;
            this.Width = width;
            this.Height = height;
            this.StrokeThickness = strokeThickness;
        }
    }
}
