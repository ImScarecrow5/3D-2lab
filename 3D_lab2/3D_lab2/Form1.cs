using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g.Clear(Color.Turquoise);

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            SolidBrush grass = new SolidBrush(Color.Green);
            g.FillRectangle(grass, 0, height - 80, width, 80);

            SolidBrush sun = new SolidBrush(Color.Yellow);
            g.FillEllipse(sun, 30, 30, 80, 80);

            SolidBrush body = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(body, width / 2 - 80, height / 2 - 30, 160, 200);

            SolidBrush head = new SolidBrush(Color.LightSalmon);
            g.FillEllipse(head, width / 2 - 60, height / 2 - 150, 120, 120);

            SolidBrush hair = new SolidBrush(Color.Brown);
            g.FillEllipse(hair, width / 2 - 35, height / 2 - 150, 70, 20);

            SolidBrush eye = new SolidBrush(Color.Black);
            g.FillRectangle(eye, width / 2 - 35, height / 2 - 110, 15, 15);
            g.FillRectangle(eye, width / 2 + 20, height / 2 - 110, 15, 15);

            SolidBrush mouth = new SolidBrush(Color.DarkRed);
            Point[] mouthPoints = new Point[]
            {
                new Point(width / 2 - 30, height / 2 - 70),
                new Point(width / 2 + 30, height / 2 - 70),
                new Point(width / 2, height / 2 - 50)
            };
            g.FillPolygon(mouth, mouthPoints);

            SolidBrush nose = new SolidBrush(Color.Salmon);
            Point[] nosePoints = new Point[]
            {
                new Point(width / 2 - 8, height / 2 - 90),
                new Point(width / 2 + 8, height / 2 - 90),
                new Point(width / 2, height / 2 - 75)
            };
            g.FillPolygon(nose, nosePoints);

            SolidBrush neck = new SolidBrush(Color.LightSalmon);
            g.FillRectangle(neck, width / 2 - 20, height / 2 - 30, 40, 30);

            SolidBrush arm = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(arm, width / 2 - 120, height / 2, 40, 20);
            g.FillRectangle(arm, width / 2 - 140, height / 2 + 15, 20, 60);

            SolidBrush hand = new SolidBrush(Color.LightSalmon);
            g.FillEllipse(hand, width / 2 - 145, height / 2 + 70, 25, 25);

            g.FillRectangle(arm, width / 2 + 80, height / 2, 40, 20);
            g.FillRectangle(arm, width / 2 + 120, height / 2 + 15, 20, 60);
            g.FillEllipse(hand, width / 2 + 120, height / 2 + 70, 25, 25);

            SolidBrush leg = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(leg, width / 2 - 70, height / 2 + 170, 30, 80);
            g.FillRectangle(leg, width / 2 + 40, height / 2 + 170, 30, 80);

            SolidBrush poyas = new SolidBrush(Color.Brown);
            g.FillRectangle(poyas, width / 2 - 85, height / 2 + 90, 170, 20);

            SolidBrush pryagka = new SolidBrush(Color.Yellow);
            g.FillRectangle(pryagka, width / 2 - 15, height / 2 + 85, 30, 30);

            SolidBrush pugovic = new SolidBrush(Color.Red);
            g.FillEllipse(pugovic, width / 2 - 10, height / 2 + 20, 20, 20);
            g.FillEllipse(pugovic, width / 2 - 10, height / 2 + 50, 20, 20);
        }
    }
}