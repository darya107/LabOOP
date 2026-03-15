using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class EllipseShape : Shape
    {
        int x, y, width, height;

        public EllipseShape(int x, int y, int w, int h, Color color): base(color)
        {
            this.x = x;
            this.y = y;
            width = w;
            height = h;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x, y, width, height);
        }
    }
}
