using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public abstract class Shape
    {
        protected Pen pen;

        public Shape(Color color, float width = 2)
        {
            pen = new Pen(color, width);
        }

        public abstract void Draw(Graphics g);
    }
}
