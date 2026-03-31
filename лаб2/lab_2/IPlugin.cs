using firstLab.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace firstLab
{
    public interface IPlugin
    {
        void Register(
      RendererFactory rendererFactory,
      ShapeCreatorFactory creatorFactory,
      ShapeDeserializerFactory deserializerFactory,
       ComboBox comboBox);
    }
}
