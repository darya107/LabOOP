using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class TriangleShape : IShape, IEditableShape
    {
        public Point P1, P2, P3;

        public TriangleShape(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public string Serialize()
        {
            return $"Triangle {P1.X} {P1.Y} {P2.X} {P2.Y} {P3.X} {P3.Y}";
        }

        public static TriangleShape Deserialize(string[] data)
        {
            return new TriangleShape(
                new Point(int.Parse(data[1]), int.Parse(data[2])),
                new Point(int.Parse(data[3]), int.Parse(data[4])),
                new Point(int.Parse(data[5]), int.Parse(data[6]))
            );
        }

        public override string ToString()
        {
            return "Triangle";
        }

        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
    {
        {"P1X", P1.X},
        {"P1Y", P1.Y},
        {"P2X", P2.X},
        {"P2Y", P2.Y},
        {"P3X", P3.X},
        {"P3Y", P3.Y}
    };
        }

        public void SetProperty(string propertyName, int value)
        {
            switch (propertyName)
            {
                case "P1X": P1.X = value; break;
                case "P1Y": P1.Y = value; break;
                case "P2X": P2.X = value; break;
                case "P2Y": P2.Y = value; break;
                case "P3X": P3.X = value; break;
                case "P3Y": P3.Y = value; break;
            }
        }

    }
}
