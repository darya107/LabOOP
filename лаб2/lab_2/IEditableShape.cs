using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLab

{
    //интерфейс для редактируемых фигур
    public interface IEditableShape : IShape
    {
        // Возвращает список свойств для редактирования
        Dictionary<string, int> GetProperties();

        // Устанавливает свойство по имени
        void SetProperty(string propertyName, int value);
    }
}
