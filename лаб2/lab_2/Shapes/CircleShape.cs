using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class CircleShape : IShape
    {
        public int X, Y, Radius;

        public CircleShape(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
}
