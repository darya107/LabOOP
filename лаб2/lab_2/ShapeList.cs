using firstLab.Render;
using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstLab
{
    public class ShapeList
    {
        private List<IShape> shapes = new List<IShape>();

        public void Add(IShape shape)
        {
            shapes.Add(shape);
        }

        public void Clear()
        {
            shapes.Clear();
        }

        public void RemoveAt(int index)
        {
            shapes.RemoveAt(index);
        }

        public List<IShape> GetAll()
        {
            return shapes;
        }

        //  Сохранение
        public void SaveToFile(string path)
        {
            File.WriteAllLines(path, shapes.Select(s => s.Serialize()));
        }

        //  Загрузка
        public void LoadFromFile(string path, ShapeDeserializerFactory factory)
        {
            shapes.Clear();

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    shapes.Add(factory.Create(line));
                }
                catch
                {
                    
                    MessageBox.Show($"Ошибка в строке: {line}");
                }
            }
        }

        public void DrawAll(Graphics g, RendererFactory factory)
        {
            foreach (var shape in shapes)
            {
                factory.Draw(shape, g);
            }
        }
    }
}
