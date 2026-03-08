using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class SquareShape : IShape
    {
        public int X, Y, Size;

        public SquareShape(int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;
        }


    }
}
