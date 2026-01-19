using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nicholl Lee Nicholl Clipping Algorithm
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clipping Square
        double Xl = 200;
        double Xr = 350;
        double Yt = 300;
        double Yb = 150;

        //line
        double P1X = 190;
        double P1Y = 190;
        double P2X = 340;
        double P2Y = 330;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);

            Point[] ClippingSquare =
            {
                new Point((int)Xl, (int)Yb),
                new Point((int)Xl, (int)Yt),
                new Point((int)Xr, (int)Yt),
                new Point((int)Xr, (int)Yb)
            };
            g.DrawPolygon(pen1, ClippingSquare);
            g.DrawLine(pen1, (int)P1X, (int)P1Y, (int)P2X, (int)P2Y);
            
            //check if line intersect left and top
            if (((P1X < Xl && P1Y >= Yb && P1Y <= Yt) || (P2X <= Xl && P2Y >= Yb && P2Y <= Yt)) &&
                ((P1Y > Yt && P1X >= Xl && P1X <= Xr) || (P2Y >= Yt && P2X >= Xl && P2X <= Xr)))
            {
                double leftIntersect_X = Xl;
                double leftIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xl - P1X);

                double topIntersect_X = P1X + (((P2X - P1X) / (P2Y - P1Y)) * (Yt - P1Y));
                double topIntersect_Y = Yt;

                g.DrawLine(pen2, (int)leftIntersect_X, (int)leftIntersect_Y, (int)topIntersect_X, (int)topIntersect_Y);
            }

            //check if line intersect right and top
            if (((P1X > Xr && P1Y >= Yb && P1Y <= Yt) || (P2X >= Xr && P2Y >= Yb && P2Y <= Yt)) &&
                ((P1Y > Yt && P1X >= Xl && P1X <= Xr) || (P2Y >= Yt && P2X >= Xl && P2X <= Xr)))
            {
                double rightIntersect_X = Xr;
                double rightIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xr - P1X);

                double topIntersect_X = P1X + (((P2X - P1X) / (P2Y - P1Y)) * (Yt - P1Y));
                double topIntersect_Y = Yt;

                g.DrawLine(pen2, (int)rightIntersect_X, (int)rightIntersect_Y, (int)topIntersect_X, (int)topIntersect_Y);
            }

            //check if line intersect bottom and top
            if (((P1Y < Yb && P1X >= Xl && P1X <= Xr) || (P2Y <= Yb && P2X >= Xl && P2X <= Xr)) &&
                ((P1Y > Yt && P1X >= Xl && P1X <= Xr) || (P2Y >= Yt && P2X >= Xl && P2X <= Xr)))
            {
                double bottomIntersect_X = P1X + ((P2X - P1X) / (P2Y - P1Y)) * (Yb - P1Y);
                double bottomIntersect_Y = Yb;

                double topIntersect_X = P1X + (((P2X - P1X) / (P2Y - P1Y)) * (Yt - P1Y));
                double topIntersect_Y = Yt;

                g.DrawLine(pen2, (int)bottomIntersect_X, (int)bottomIntersect_Y, (int)topIntersect_X, (int)(topIntersect_Y));
            }

            //check if line intersect left and bottom
            if (((P1X < Xl && P1Y >= Yb && P1Y <= Yt) || (P2X <= Xl && P2Y >= Yb && P2Y <= Yt)) &&
                ((P1Y < Yb && P1X >= Xl && P1X <= Xr) || (P2Y <= Yb && P2X >= Xl && P2X <= Xr)))
            {
                double leftIntersect_X = Xl;
                double leftIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xl - P1X);

                double bottomIntersect_X = P1X + ((P2X - P1X) / (P2Y - P1Y)) * (Yb - P1Y);
                double bottomIntersect_Y = Yb;

                g.DrawLine(pen2, (int)leftIntersect_X, (int)leftIntersect_Y, (int)bottomIntersect_X, (int)bottomIntersect_Y);
            }

            //check if line intersect right and bottom
            if (((P1X > Xr && P1Y >= Yb && P1Y <= Yt) || (P2X >= Xr && P2Y >= Yb && P2Y <= Yt)) &&
                ((P1Y < Yb && P1X >= Xl && P1X <= Xr) || (P2Y <= Yb && P2X >= Xl && P2X <= Xr)))
            {
                double rightIntersect_X = Xr;
                double rightIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xr - P1X);

                double bottomIntersect_X = P1X + ((P2X - P1X) / (P2Y - P1Y)) * (Yb - P1Y);
                double bottomIntersect_Y = Yb;

                g.DrawLine(pen2, (int)rightIntersect_X, (int)rightIntersect_Y, (int)bottomIntersect_X, (int)bottomIntersect_Y);
            }

            //check if line intersect left and right
            if (((P1X < Xl && P1Y >= Yb && P1Y <= Yt) || (P2X <= Xl && P2Y >= Yb && P2Y <= Yt)) &&
                ((P1X > Xr && P1Y >= Yb && P1Y <= Yt) || (P2X >= Xr && P2Y >= Yb && P2Y <= Yt)))
            {
                double leftIntersect_X = Xl;
                double leftIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xl - P1X);

                double rightIntersect_X = Xr;
                double rightIntersect_Y = P1Y + ((P2Y - P1Y) / (P2X - P1X)) * (Xr - P1X);

                g.DrawLine(pen2, (int)leftIntersect_X, (int)leftIntersect_Y, (int)rightIntersect_X, (int)rightIntersect_Y);
            }
        }

    }
}
