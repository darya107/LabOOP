using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public class ShapeDeserializerFactory
    {
        private Dictionary<string, Func<string[], IShape>> creators =
            new Dictionary<string, Func<string[], IShape>>();

        public void Register(string key, Func<string[], IShape> creator)
        {
            creators[key] = creator;
        }

        public IShape Create(string line)
        {
            var parts = line.Split(' ');

            if (!creators.ContainsKey(parts[0]))
                throw new Exception("Неизвестный тип фигуры");

            return creators[parts[0]](parts);
        }
    }
}
