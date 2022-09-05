using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlite
{
    public partial class MainHex : Form
    {
        public MainHex()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void MainHex_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            //formGraphics.FillRectangle(myBrush, new Rectangle(411, 253, 40, 40));
            //DrawCurvePointF(e);
            //DrawhexagonF(e,70F,70F);
            int length = 0;
            float x = 70F;
            float y = 70F;

            while (length < 10)
            {
                drawrow(e, x, y);
                if (length % 2 == 0)
                {
                    x = 70F+75F;
                    y = y + 43.3013F;
                }
                else
                {
                    x = 70F;
                    y = y + 43.3013F;
                }
                length++;

            }
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        private void drawrow(PaintEventArgs e, float x, float y)
        {
            int width = 0;
            while (width < 6)
            {
                DrawhexagonF(e, x, y);
                x = x + 150F;
                width++;
            }
        }
        private void DrawCurvePointF(PaintEventArgs e)
        {

            // Create pens.
            Pen redPen = new Pen(Color.Red, 3);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points that define curve.
            PointF point1 = new PointF(70F, 70F);
            PointF point2 = new PointF(120F, 120F);
            PointF point3 = new PointF(95F, 120F);
            PointF point4 = new PointF(70F, 145F);
            PointF point5 = new PointF(45F, 145F);
            PointF point6 = new PointF(20F, 120F);
            PointF point7 = new PointF(20F, 95F);
            PointF point8 = new PointF(45F, 70F);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8, point1 };

            // Draw lines between original points to screen.
            e.Graphics.DrawLines(redPen, curvePoints);

            // Draw curve to screen.
            //e.Graphics.DrawCurve(greenPen, curvePoints);
        }
        private void DrawhexagonF(PaintEventArgs e, float x, float y)
        {

            // Create pens.
            Pen redPen = new Pen(Color.Red, 1);
            Pen greenPen = new Pen(Color.Green, 3);

            // Create points X,Y creates a starting point when you call the fucntion 
            PointF point1 = new PointF(x, y);
            PointF point2 = new PointF(x + 50F, y);
            PointF point3 = new PointF(x + 75F, y + 43.302F);
            PointF point4 = new PointF(x + 50F, y + 86.6025F);
            PointF point5 = new PointF(x, y + 86.604F);
            PointF point6 = new PointF(x - 25F, y + 43.302F);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point1 };

            // Draw lines between original points to screen.
            e.Graphics.DrawLines(redPen, curvePoints);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            
        }
    }
}

