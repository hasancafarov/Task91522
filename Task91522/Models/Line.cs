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
using Task91522.Models.Abstract;
using Task91522.Utils;

namespace Task91522.Models
{
    internal class Line : LinearShape
    {
        public Line(Point[] points, Color color) : base(points, color)
        {
        }

        public override Shape GetRelativeShape(Point canvasCenter, double scaleFactor, SolidColorBrush brush)
        {
            var relativePoints = Points.ToArray();
            relativePoints = GeometryUtil.GetRelativePointArray(relativePoints, canvasCenter, scaleFactor);

            return new System.Windows.Shapes.Line
            {
                Stroke = brush,
                X1 = relativePoints[0].X,
                X2 = relativePoints[1].X,
                Y1 = relativePoints[0].Y,
                Y2 = relativePoints[1].Y,
                StrokeThickness = 2
            };
        }
    }
}
