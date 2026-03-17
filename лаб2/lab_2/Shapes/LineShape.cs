using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab.Shapes
{
    public class LineShape : IShape, IEditableShape
    {
        public int X1, Y1, X2, Y2;

        public LineShape(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public string Serialize()
        {
            return $"Line {X1} {Y1} {X2} {Y2}";
        }

        public static LineShape Deserialize(string[] data)
        {
            return new LineShape(
                int.Parse(data[1]),
                int.Parse(data[2]),
                int.Parse(data[3]),
                int.Parse(data[4]));
        }

        public override string ToString()
        {
            return "Line";
        }

        public Dictionary<string, int> GetProperties()
        {
            return new Dictionary<string, int>
    {
        {"X1", X1},
        {"Y1", Y1},
        {"X2", X2},
        {"Y2", Y2}
    };
        }

        public void SetProperty(string propertyName, int value)
        {
            switch (propertyName)
            {
                case "X1": X1 = value; break;
                case "Y1": Y1 = value; break;
                case "X2": X2 = value; break;
                case "Y2": Y2 = value; break;
            }
        }


    }
}
