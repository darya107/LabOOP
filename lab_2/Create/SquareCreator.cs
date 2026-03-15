using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Create
{
    
    public class SquareCreator : IShapeCreator
    {
        public IShape Create(Point start, Point end)
        {
            int side = Math.Min(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
            return new SquareShape(start.X, start.Y, side);
        }
    }
}
