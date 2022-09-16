using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using Task91522.Models.Abstract;
using Task91522.Utils;
using Color = System.Drawing.Color;
using Point = System.Windows.Point;
using Shape = System.Windows.Shapes.Shape;

namespace Task91522.Models
{
    public class Ellipse : IShape
    {
        public Point Center { get; }
        public double Radius { get; }
        public bool IsFilled { get; }
        public Color Color { get; }

        public Shape GetRelativeShape(Point canvasCenter, double scaleFactor, SolidColorBrush brush)
        {
            var scaledRadius = GeometryUtil.GetRadius(Radius, scaleFactor);
            var ellipse = new EllipseGeometry
            {
                Center = GeometryUtil.GetRelativePoint(Center, canvasCenter, scaleFactor),
                RadiusX = scaledRadius,
                RadiusY = scaledRadius
            };
            var path = new Path
            {
                Stroke = brush,
                Data = ellipse
            };
            return path;
        }

        public Point GetMaximumShapePoints()
        {
            return new Point(Radius, Radius);
        }

        public Ellipse(Point center, double radius, bool isFilled, Color color)
        {
            Center = center;
            Radius = radius;
            IsFilled = isFilled;
            Color = color;
        }
    }
}
