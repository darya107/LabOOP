using firstLab;
using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonPlugin
{
    public class HexagonCreator : IShapeCreator
    {
        public IShape Create(Point start, Point end)
        {
            int size = Math.Min(
                Math.Abs(end.X - start.X),
                Math.Abs(end.Y - start.Y));

            return new HexagonShape(start.X, start.Y, size);
        }
    }
}
