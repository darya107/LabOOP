using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class EllipseShape : IShape, IEditableShape
    {
        public int X, Y, Width, Height;

        public EllipseShape(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Serialize()
        {
            return $"Ellipse {X} {Y} {Width} {Height}";
        }

        public static EllipseShape Deserialize(string[] data)
        {
            return new EllipseShape(
                int.Parse(data[1]),
                int.Parse(data[2]),
                int.Parse(data[3]),
                int.Parse(data[4]));
        }

        public override string ToString()
        {
            return "Ellipse"; 
        }

        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
    {
        {"X", X},
        {"Y", Y},
        {"Width", Width},
        {"Height", Height}
    };
        }

        public void SetProperty(string propertyName, int value)
        {
            switch (propertyName)
            {
                case "X": X = value; break;
                case "Y": Y = value; break;
                case "Width": Width = value; break;
                case "Height": Height = value; break;
            }
        }

    }
}
