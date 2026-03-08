using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    internal class RectangleRenderer :IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var rect = (RectangleShape)shape;
            g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
        }
    }
}
