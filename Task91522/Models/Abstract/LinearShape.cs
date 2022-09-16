using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using Point = System.Windows.Point;
using Shape = System.Windows.Shapes.Shape;

namespace Task91522.Models.Abstract
{
    internal abstract class LinearShape : IShape
    {
        public Point[] Points { get; set; }
        public Color Color { get; set; }

        protected LinearShape(Point[] points, Color color)
        {
            Points = points;
            Color = color;
        }

        public virtual Shape GetRelativeShape(Point canvasCenter, double scaleFactor, SolidColorBrush brush)
        {
            throw new NotImplementedException();
        }

        public virtual Point GetMaximumShapePoints()
        {
            return new Point(Points.Select(max => Math.Abs(max.X)).Max(), Points.Select(max => Math.Abs(max.Y)).Max());
        }
    }
}
