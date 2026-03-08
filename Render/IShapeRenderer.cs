using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public interface IShapeRenderer
    {
        void Draw(IShape shape, Graphics g);
    }
}
