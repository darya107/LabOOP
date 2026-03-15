using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class LineShape : Shape
    {
        int x1, y1, x2, y2;

        public LineShape(int x1, int y1, int x2, int y2, Color color) : base(color)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
