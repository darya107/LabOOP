using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class SquareShape : Shape
    {
        int x, y, size;

        public SquareShape(int x, int y, int size, Color color) : base(color)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, x, y, size, size);
        }
    }
}
