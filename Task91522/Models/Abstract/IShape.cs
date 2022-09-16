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
    public interface IShape
    {
        public Color Color { get; }

        public Shape GetRelativeShape(Point canvasCenter, double scaleFactor, SolidColorBrush brush);

        public Point GetMaximumShapePoints();
    }
}
