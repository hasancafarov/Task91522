using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task91522.Models.Abstract;
using Point = System.Windows.Point;

namespace Task91522.Models
{
    internal class Triangle : PolygonShape
    {
        public Triangle(Point[] points, Color color, bool isFilled) : base(points, color, isFilled)
        {
        }
    }
}
