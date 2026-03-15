using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public class TriangleCreator : IShapeCreator
    {
        //создает фигуру
        public IShape Create(Point start, Point end)
        {
            return new TriangleShape(
                start,
                new Point(end.X, start.Y),
                end
            );
        }
    }
}
