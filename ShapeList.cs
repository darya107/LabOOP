using firstLab.Render;
using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public class ShapeList
    {
        private List<IShape> shapes = new List<IShape>();

        public void Add(IShape shape)
        {
            shapes.Add(shape);
        }

        public void DrawAll(Graphics g, RendererFactory factory)
        {
            foreach (var shape in shapes)
            {
                factory.Draw(shape, g);
            }
        }
    }
}
