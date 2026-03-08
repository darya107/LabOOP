using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Render
{
    public class RendererFactory
    {
        private Dictionary<Type, IShapeRenderer> renderers
        = new Dictionary<Type, IShapeRenderer>();

        public void Register<T>(IShapeRenderer renderer)
        {
            renderers[typeof(T)] = renderer;
        }

        public void Draw(IShape shape, Graphics g)
        {
            renderers[shape.GetType()].Draw(shape, g);
        }
    }
}
