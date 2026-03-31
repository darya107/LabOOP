using firstLab;
using firstLab.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexagonPlugin
{
    internal class HexagonPlugin : IPlugin
    {
        public void Register(
        RendererFactory rendererFactory,
        ShapeCreatorFactory creatorFactory,
        ShapeDeserializerFactory deserializerFactory,
        ComboBox comboBox)
        {
            // Hexagon
            rendererFactory.Register<HexagonShape>(new HexagonRenderer());
            creatorFactory.Register<HexagonShape>(new HexagonCreator());
            deserializerFactory.Register("Hexagon", data => HexagonShape.Deserialize(data));
            comboBox.Items.Add(new ShapeItem("Hexagon", typeof(HexagonShape)));

            // Star
            rendererFactory.Register<StarShape>(new StarRenderer());
            creatorFactory.Register<StarShape>(new StarCreator());
            deserializerFactory.Register("Star", data => StarShape.Deserialize(data));
            comboBox.Items.Add(new ShapeItem("Star", typeof(StarShape)));
        }
    }
}
