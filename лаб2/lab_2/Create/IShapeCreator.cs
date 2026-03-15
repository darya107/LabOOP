using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public interface IShapeCreator
    {
        IShape Create(Point start, Point end);
    }
}
