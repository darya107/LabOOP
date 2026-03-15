using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    public class EllipseRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var ellipse = (EllipseShape)shape;
            g.DrawEllipse(Pens.Black,
                          ellipse.X,
                          ellipse.Y,
                          ellipse.Width,
                          ellipse.Height);
        }
    }
}
