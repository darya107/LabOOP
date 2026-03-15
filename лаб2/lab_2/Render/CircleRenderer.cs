using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    internal class CircleRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var circle = (CircleShape)shape;
            g.DrawEllipse(Pens.Black, circle.X, circle.Y,
                          circle.Radius * 2, circle.Radius * 2);
        }
    }
}
