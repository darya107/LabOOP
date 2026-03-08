using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    public class LineRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var line = (LineShape)shape;
            g.DrawLine(Pens.Black, line.X1, line.Y1, line.X2, line.Y2);
        }
    }
}
