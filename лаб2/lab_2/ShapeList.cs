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
        public void SaveToFile(string path, IProcessingPlugin plugin)
        {
            var lines = shapes.Select(s => s.Serialize()).ToList();

            if (plugin != null)
            {
                lines = lines.Select(l => plugin.ProcessBeforeSave(l)).ToList();
                lines.Insert(0, $"#ENC:{plugin.Name}");
            }
            else
            {
                lines.Insert(0, "#ENC:NONE");
            }

            File.WriteAllLines(path, lines);
        }

        //  Загрузка
        public void LoadFromFile(string path, ShapeDeserializerFactory factory, List<IProcessingPlugin> plugins,
        ComboBox comboBoxProcessing)
        {
            shapes.Clear();

            var lines = File.ReadAllLines(path).ToList();

            if (lines.Count == 0)
                return;

            //  читаю заголовок
            string header = lines[0];
            lines.RemoveAt(0);

            IProcessingPlugin currentPlugin = null;

            if (header.StartsWith("#ENC:"))
            {
                string encName = header.Substring(5);

                currentPlugin = plugins
                    .FirstOrDefault(p => p.Name == encName);

                // устанавливаю в UI
                if (currentPlugin != null)
                    comboBoxProcessing.SelectedItem = currentPlugin;
                else
                    comboBoxProcessing.SelectedIndex = -1;
            }

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string processed = currentPlugin != null
                    ? currentPlugin.ProcessAfterLoad(line)
                    : line;

                shapes.Add(factory.Create(processed));
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
