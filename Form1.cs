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
        private string selectedShape = "Rectangle";
       // ShapeList list = new ShapeList();
        public Form1()
        {
            InitializeComponent();

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

            comboBox1.SelectedIndex = 0;

            comboBox1.SelectedIndexChanged += (s, e) =>
            {
                var item = (ShapeItem)comboBox1.SelectedItem;
                selectedShapeType = item.ShapeType;
            };
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Рисуем все фигуры через ShapeList
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

            var shape = creatorFactory.Create(
                selectedShapeType,
                startPoint,
                e.Location);

            shapeList.Add(shape);

            Invalidate();

        }
    }
    
}
