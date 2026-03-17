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
    public partial class MyEditShapeForm : Form
    {

        private IEditableShape shape;
        public MyEditShapeForm(IEditableShape shape)
        {
            InitializeComponent();
            this.shape = shape ?? throw new ArgumentNullException(nameof(shape));


            int y = 10;
            foreach (var kv in shape.GetProperties())
            {
                var label = new Label
                {
                    Text = kv.Key,
                    Location = new Point(10, y),
                    Width = 60,
                    ForeColor = Color.Black
                };
                var textBox = new TextBox
                {
                    Text = kv.Value.ToString(),
                    Location = new Point(80, y),
                    Width = 100,
                    Name = kv.Key
                };
                this.Controls.Add(label);
                this.Controls.Add(textBox);
                y += 30;
            }

            // --- кнопка OK ---
            buttonOk.Click += buttonOk_Click;

            // --- кнопка Cancel ---
            buttonCancel.Click += (s, e) => this.Close();
        }

        private void MyEditShapeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // сохраняем новые значения свойств фигуры
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb && int.TryParse(tb.Text, out int value))
                {
                    shape.SetProperty(tb.Name, value);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
