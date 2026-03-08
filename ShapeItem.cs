using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab
{
    public class ShapeItem
    {
        public string Name { get; }
        public Type ShapeType { get; }

        public ShapeItem(string name, Type type)
        {
            Name = name;
            ShapeType = type;
        }

        public override string ToString()
        {
            return Name; // что будет отображаться в ComboBox
        }
    }
}
