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
    public class StarRenderer : IShapeRenderer
    {

        public void Draw(IShape shape, Graphics g)
        {
            var s = (StarShape)shape;

            Point[] points = new Point[10];

            for (int i = 0; i < 10; i++)
            {
                double angle = Math.PI / 5 * i;
                int radius = (i % 2 == 0) ? s.Size : s.Size / 2;

                points[i] = new Point(
                    s.X + (int)(radius * Math.Cos(angle)),
                    s.Y + (int)(radius * Math.Sin(angle))
                );
            }

            g.DrawPolygon(Pens.Black, points);
        }
    }
}
