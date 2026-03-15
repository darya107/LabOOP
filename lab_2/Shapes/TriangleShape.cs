using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class TriangleShape : IShape
    {
        public Point P1, P2, P3;

        public TriangleShape(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

    }
}
