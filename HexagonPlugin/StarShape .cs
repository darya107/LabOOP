using firstLab;
using firstLab.Shapes;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonPlugin
{
    public class StarShape : IShape, IEditableShape
    {
        public int X, Y, Size;

        public StarShape(int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;
        }

        public string Serialize()
        {
            return $"Star {X} {Y} {Size}";
        }

        public static StarShape Deserialize(string[] data)
        {
            return new StarShape(
                int.Parse(data[1]),
                int.Parse(data[2]),
                int.Parse(data[3]));
        }

        public override string ToString() => "Star";

        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
        {
            {"X", X},
            {"Y", Y},
            {"Size", Size}
        };
        }

        public void SetProperty(string propertyName, int value)
        {
            switch (propertyName)
            {
                case "X": X = value; break;
                case "Y": Y = value; break;
                case "Size": Size = value; break;
            }
        }
    }
}
