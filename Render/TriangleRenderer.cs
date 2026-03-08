using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    public class TriangleRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var triangle = (TriangleShape)shape;
            g.DrawPolygon(Pens.Black,
                new Point[] { triangle.P1, triangle.P2, triangle.P3 });
        }
    }
}
