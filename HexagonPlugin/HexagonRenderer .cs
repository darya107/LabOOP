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
    public class HexagonRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var h = (HexagonShape)shape;

            Point[] points = new Point[6];

            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i;

                points[i] = new Point(
                    h.X + (int)(h.Size * Math.Cos(angle)),
                    h.Y + (int)(h.Size * Math.Sin(angle))
                );
            }

            g.DrawPolygon(Pens.Black, points);
        }
    }
}

