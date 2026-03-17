using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class CircleShape : IShape, IEditableShape
    {
        public int X, Y, Radius;

        public CircleShape(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public string Serialize()
        {
            return $"Circle {X} {Y} {Radius}";
        }

        public static CircleShape Deserialize(string[] data)
        {
            return new CircleShape(
                int.Parse(data[1]),
                int.Parse(data[2]),
                int.Parse(data[3]));
        }

        public override string ToString()
        {
            return "Circle"; 
        }

        // --- Редактирование ---
        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
        {
            { "X", X },
            { "Y", Y },
            { "Radius", Radius }
        };
        }

        public void SetProperty(string propertyName, int value)
        {
            switch (propertyName)
            {
                case "X": X = value; break;
                case "Y": Y = value; break;
                case "Radius": Radius = value; break;
            }
        }
    }
}
