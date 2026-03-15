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
        ShapeList list = new ShapeList();
        public Form1()
        {
            InitializeComponent();

            this.Width = 800;
            this.Height = 600;

            list.Add(new LineShape(150, 80, 300, 80, Color.Red));
            list.Add(new RectangleShape(350, 50, 120, 80, Color.Blue));
            list.Add(new EllipseShape(550, 50, 120, 80, Color.Green));
            list.Add(new CircleShape(200, 300, 60, Color.Purple));
            list.Add(new SquareShape(370, 280, 100, Color.Orange));
            list.Add(new TriangleShape(
               new Point(600, 280),
               new Point(670, 380),
               new Point(530, 380),
               Color.Brown));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            list.DrawAll(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
