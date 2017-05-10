using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        PlaiyingField field;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            field = new PlaiyingField(50, 50);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // контур
            Pen pen = new Pen(Color.Black);
            pen.Width = 1;
            // заливка
            Brush brush = new SolidBrush(Color.Black);
            // коэфициент увеличения
            int k = 3;
            // прорисовка поля
            e.Graphics.DrawRectangle(pen, field.pointField.X, field.pointField.Y, field.col * field.sizeCell * k, field.row * field.sizeCell * k);

            //foreach (var it in field.fieldList)
            //{
            //    e.Graphics.FillRectangle(brush, field.pointField.X + it.X * k, field.pointField.Y + it.Y * k, it.Width * k, it.Height * k);
            //    e.Graphics.DrawRectangle(pen, field.pointField.X + it.X * k, field.pointField.Y + it.Y * k, it.Width * k, it.Height * k);
            //}
        }

    }
}
