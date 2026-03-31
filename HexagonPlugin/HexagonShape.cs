using firstLab;
using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HexagonPlugin
{
    public class HexagonShape : IShape, IEditableShape
    {
        public int X, Y, Size;

        public HexagonShape(int x, int y, int size)
        {
            X = x;
            Y = y;
            Size = size;
        }

        public string Serialize()
        {
            return $"Hexagon {X} {Y} {Size}";
        }

        public static HexagonShape Deserialize(string[] data)
        {
            return new HexagonShape(
                int.Parse(data[1]),
                int.Parse(data[2]),
                int.Parse(data[3]));
        }

        public override string ToString() => "Hexagon";

        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
        {
            { "X", X },
            { "Y", Y },
            { "Size", Size }
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
