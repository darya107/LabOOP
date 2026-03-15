using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class RectangleShape : Shape
    {
        int x, y, width, height;

        public RectangleShape(int x, int y, int w, int h, Color color) : base(color)
            //вызов конструктора базового класса
        {
            this.x = x;
            this.y = y;
            width = w;
            height = h;
        }

        public override void Draw(Graphics g)//переопределение виртуального метода
        {
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}
