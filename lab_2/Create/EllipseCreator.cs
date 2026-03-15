using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class EllipseCreator : IShapeCreator
    {
        public IShape Create(Point start, Point end)
        {
            return new EllipseShape(
                start.X,
                start.Y,
                end.X - start.X,
                end.Y - start.Y);
        }
    }
}
