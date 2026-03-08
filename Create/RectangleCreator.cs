using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Create
{
    public class RectangleCreator : IShapeCreator
    {
        public IShape Create(Point start, Point end)
        {
            return new RectangleShape(
                start.X,
                start.Y,
                end.X - start.X,
                end.Y - start.Y);
        }
    }
}
