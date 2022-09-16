using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;
using Task91522.Utils;
using Color = System.Drawing.Color;
using Point = System.Windows.Point;
using Shape = System.Windows.Shapes.Shape;
using System.Windows.Media;

namespace Task91522.Models.Abstract
{
    internal class PolygonShape : LinearShape
    {
        bool IsFilled { get; }

        protected PolygonShape(Point[] points, Color color, bool isFilled) : base(points, color)
        {
            IsFilled = isFilled;
        }

        public override Shape GetRelativeShape(Point canvasCenter, double scaleFactor, SolidColorBrush brush)
        {
            var relativePoints = Points.ToArray();
            relativePoints = GeometryUtil.GetRelativePointArray(relativePoints, canvasCenter, scaleFactor);

            var polygon = new Polygon
            {
                Stroke = brush,
                StrokeThickness = 2
            };

            if (IsFilled)
                polygon.Fill = brush;

            foreach (var point in relativePoints)
            {
                polygon.Points.Add(point);
            }

            return polygon;
        }
    }
}
