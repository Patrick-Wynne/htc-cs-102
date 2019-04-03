using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Individual
{
    public class Pentagon : Shape
    {
        protected override Geometry DefiningGeometry
        {
            get
            {
                PathFigure myPathFigure = new PathFigure();
                myPathFigure.StartPoint = new Point(Width / 2, 0);

                LineSegment segment1 = new LineSegment();
                segment1.Point = new Point(Width, Height / 2);
                LineSegment segment2 = new LineSegment();
                segment2.Point = new Point(Width*0.75, Height);
                LineSegment segment3 = new LineSegment();
                segment3.Point = new Point(Width*0.25, Height);
                LineSegment segment4 = new LineSegment();
                segment4.Point = new Point(0, Height/2);
                LineSegment segment5 = new LineSegment();
                segment5.Point = new Point(Width / 2, 0);

                PathSegmentCollection myPathSegmentCollection = new PathSegmentCollection();
                myPathSegmentCollection.Add(segment1);
                myPathSegmentCollection.Add(segment2);
                myPathSegmentCollection.Add(segment3);
                myPathSegmentCollection.Add(segment4);
                myPathSegmentCollection.Add(segment5);

                myPathFigure.Segments = myPathSegmentCollection;

                PathFigureCollection myPathFigureCollection = new PathFigureCollection();
                myPathFigureCollection.Add(myPathFigure);

                PathGeometry myPathGeometry = new PathGeometry();
                myPathGeometry.Figures = myPathFigureCollection;

                return myPathGeometry;


            }
        }
        public Pentagon(Brush strokeColor, Brush fillColor, double strokeThickness, int width, int height)
        {
            this.Stroke = strokeColor;
            this.Fill = fillColor;
            this.Width = width;
            this.Height = height;
            this.StrokeThickness = strokeThickness;
        }
    }
}
