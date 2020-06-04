using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphCycles
{
    public partial class GraphCycle1 : Form
    {
        Graphics g;
        Pen p;

        public GraphCycle1()
        {
            InitializeComponent();
            initGraph();
        }
        void initGraph()
        {
            Bitmap bmp = new Bitmap(GraphCycle.Width, GraphCycle.Height);
            GraphCycle.Image = bmp;
            g = Graphics.FromImage(bmp);
            p = new Pen(Color.DarkRed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int y = 0; y <= 600; y += 20)
            {
                drawLine(0, y, 600, y);
            }
        }

        void drawLine(int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2);
            Thread.Sleep(20);
            GraphCycle.Refresh();
        }

        private void Сброс_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            GraphCycle.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= 600; x += 20)
            {
                drawLine(x, 0, x, 600);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int a = 0; a <= 600; a += 20)
            {
                drawLine(a, 0, 0, a);
            }
            for (int a = 600; a >= 600; a -= 20)
            {
                drawLine(-a, 0, 0, -a);
            }
        }
    }
}
