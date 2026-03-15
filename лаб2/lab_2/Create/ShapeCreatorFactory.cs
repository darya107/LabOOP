using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public class ShapeCreatorFactory
    {
        //ключ   → Type
        //значение → IShapeCreator
        private Dictionary<Type, IShapeCreator> creators
       = new Dictionary<Type, IShapeCreator>();

        public void Register<T>(IShapeCreator creator)
        {
            creators[typeof(T)] = creator;
        }

        public IShape Create(Type type, Point start, Point end)
        {
            return creators[type].Create(start, end);
        }
    }
}
