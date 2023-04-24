using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point[] puntos = { new Point(30, 45), new Point(110, 75), new Point(175, 200) };
            g.FillClosedCurve(Brushes.Aquamarine, puntos);

            g.FillEllipse(Brushes.BlueViolet, new Rectangle(75, 30, 100, 25));

            Point[] puntos2 = { new Point(10, 145), new Point(200, 50), new Point(100, 220) };
            g.FillPolygon(Brushes.LightGoldenrodYellow, puntos2);

            g.DrawRectangle(Pens.Black, new Rectangle(200, 100, 30, 75));
            g.FillRectangle(Brushes.Pink, new Rectangle(200, 100, 30, 75));

        }
    }
}
