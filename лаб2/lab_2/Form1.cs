using firstLab.Create;
using firstLab.Render;
using firstLab.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstLab
{

    public partial class Form1 : Form
    {
        private ShapeList shapeList = new ShapeList();
        private RendererFactory rendererFactory = new RendererFactory();
        private Type selectedShapeType;
        private ShapeCreatorFactory creatorFactory = new ShapeCreatorFactory();
        private Point startPoint;
        private ShapeDeserializerFactory deserializerFactory = new ShapeDeserializerFactory();

        public Form1()
        {
            InitializeComponent();
            //регистрация
            rendererFactory.Register<RectangleShape>(new RectangleRenderer());
            rendererFactory.Register<CircleShape>(new CircleRenderer());
            rendererFactory.Register<LineShape>(new LineRenderer());
            rendererFactory.Register<EllipseShape>(new EllipseRenderer());
            rendererFactory.Register<SquareShape>(new SquareRenderer());
            rendererFactory.Register<TriangleShape>(new TriangleRenderer());

            comboBox1.Items.Add(new ShapeItem("Rectangle", typeof(RectangleShape)));
            comboBox1.Items.Add(new ShapeItem("Circle", typeof(CircleShape)));
            comboBox1.Items.Add(new ShapeItem("Line", typeof(LineShape)));
            comboBox1.Items.Add(new ShapeItem("Ellipse", typeof(EllipseShape)));
            comboBox1.Items.Add(new ShapeItem("Square", typeof(SquareShape)));
            comboBox1.Items.Add(new ShapeItem("Triangle", typeof(TriangleShape)));

            creatorFactory.Register<RectangleShape>(new RectangleCreator());
            creatorFactory.Register<CircleShape>(new CircleCreator());
            creatorFactory.Register<LineShape>(new LineCreator());
            creatorFactory.Register<EllipseShape>(new EllipseCreator());
            creatorFactory.Register<SquareShape>(new SquareCreator());
            creatorFactory.Register<TriangleShape>(new TriangleCreator());

            deserializerFactory.Register("Circle", data => CircleShape.Deserialize(data));
            deserializerFactory.Register("Rectangle", data => RectangleShape.Deserialize(data));
            deserializerFactory.Register("Line", data => LineShape.Deserialize(data));
            deserializerFactory.Register("Ellipse", data => EllipseShape.Deserialize(data));
            deserializerFactory.Register("Square", data => SquareShape.Deserialize(data));
            deserializerFactory.Register("Triangle", data => TriangleShape.Deserialize(data));

            comboBox1.SelectedIndex = -1;

            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                var item = (ShapeItem)comboBox1.SelectedItem;
                selectedShapeType = item.ShapeType;
            };
        }

        private void UpdateListBox()
        {
            listBoxShapes.Items.Clear();

            foreach (var shape in shapeList.GetAll())
            {
                listBoxShapes.Items.Add(shape);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //отрисовка
            shapeList.DrawAll(e.Graphics, rendererFactory);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShapeType == null) return;
            //создает фигуру
            var shape = creatorFactory.Create(
                selectedShapeType,
                startPoint,
                e.Location);

            shapeList.Add(shape);
            UpdateListBox();

            Invalidate();// рисует фигуру

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            shapeList.Clear();   // очищаем список фигур
            UpdateListBox();
            Invalidate();        // перерисовываем форму
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            shapeList.SaveToFile("shapes.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            shapeList.LoadFromFile("shapes.txt", deserializerFactory);
            UpdateListBox();
            Invalidate();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxShapes.SelectedIndex;

            if (index >= 0)
            {
                shapeList.RemoveAt(index);
                UpdateListBox();
                Invalidate();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxShapes.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Выберите фигуру для редактирования!");
                return;
            }

            var shape = shapeList.GetAll()[index];

            if (shape is IEditableShape editableShape)
            {
                var editForm = new MyEditShapeForm(editableShape);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateListBox(); // обновляем ListBox
                    Invalidate();   // перерисовываем фигуру
                }
            }
            else
            {
                MessageBox.Show("Эта фигура не поддерживает редактирование.");
            }
        }
    }
    
}
