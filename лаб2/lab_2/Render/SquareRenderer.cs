using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    public class SquareRenderer : IShapeRenderer
    {
        public void Draw(IShape shape, Graphics g)
        {
            var square = (SquareShape)shape;
            g.DrawRectangle(Pens.Black,
                            square.X,
                            square.Y,
                            square.Size,
                            square.Size);
        }
    }
}
