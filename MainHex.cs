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
        List<HexModel> Hexs = new List<HexModel>();
        public MainHex()
        {
            InitializeComponent();
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);
            //InitializeHexDb();
        }
        private void MainHex_Load(object sender, EventArgs e)
        {

        }
        public void InitializeHexDb()
        {
            HexModel hex = new HexModel();
            SqliteDataAccess.DeleteAllHex();

            int i = 1;
            int a = 1;
            while (i <= 12)
            {
                while (a <= 5)
                {
                    hex.Number = a.ToString() + "," + i.ToString();
                   
                    SqliteDataAccess.MakeHex(hex);
                    a++;
                }
                i++;
                a = 1;
            }

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
                    x = 70F + 75F;
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

        private void MainHex_MouseClick(object sender, MouseEventArgs e)
        {
            int mx = e.X;
            int my = e.Y;
            FindHexColumn(mx, my);
        }
        private void FindHexColumn(int mx, int my)
        {
            int i = 1;
            int X = 70;
            while (i <= 12)
            {
                if (X < mx && (X + 50) > mx)
                {
                    // found colum find row
                    FindHexRow(mx, my, i);
                    break;
                }
                else
                {
                    i++;
                    X = X + 75;
                }
            }
        }

        private void FindHexRow(int Mx, int My, int Row)
        {
            int count = 1;
            int Y = 70;
            if (Row % 2 == 0)
            {
                Y = Y + 43;
            }
            while (count < 6)
            {
                if (Y < My && (Y + 86) > My)
                {
                    label1.Text = "Row:" + Row + "Column: " + count;

                    //fetch and display infomation.
                    break;
                }
                else
                {
                    count++;
                    Y = Y + 86;
                }
            }

            DisplayHexInfo(Row, count);
            
        }
        private void DisplayHexInfo(int R, int C)
        {
            string Column = C.ToString();
            string Row = R.ToString();
            Hexs = SqliteDataAccess.loadHex(Column, Row);
            if (Hexs.CompanyPresent != null) 
            {

            }
            WireUpNumberList();
            WireUpTerrainList();
        }
        private void WireUpNumberList()
        {
            HexNum1.DataSource = null;
            HexNum1.DataSource = Hexs;
            HexNum1.DisplayMember = "Number";


        }
        private void WireUpTerrainList()
        {
            TerrainBox.DataSource = null;
            TerrainBox.DataSource = Hexs;
            TerrainBox.DisplayMember = "Terrain";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    HexModel H = new HexModel();
        //    H.Number = "10,2";
        //    H.Terrain = "rocks, lots of rocks";
        //    H.CompanyPresent = "THE MADDER MEN";
        //    SqliteDataAccess.MakeHex(H);
        //}
    }
}

