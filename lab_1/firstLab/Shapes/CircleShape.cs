using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class CircleShape : Shape
    {
        int x, y, radius;

        public CircleShape(int x, int y, int r, Color color) : base(color)
        {
            this.x = x;
            this.y = y;
            radius = r;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, x, y, radius * 2, radius * 2);
        }
    }
}
