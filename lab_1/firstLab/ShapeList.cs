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
        private List<Shape> shapes = new List<Shape>();

        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape s in shapes)
            {
                s.Draw(g);   // динамический полиморфизм
            }
        }
    }
}
