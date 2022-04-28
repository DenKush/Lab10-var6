using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа_10.Вариант_6
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
            Pen p = new Pen(Brushes.Black, 2);
            g.DrawLine(p, 0, 330, this.Size.Width, 330);
            g.DrawLine(p, 400, 330, 400, 160);
            g.DrawLine(p, 200, 160, 250, 90);
            g.DrawLine(p, 250, 90, 450, 90);
            g.DrawLine(p, 450, 90, 500, 160);
            g.DrawLine(p, 350, 90, 400, 160);
            g.DrawRectangle(p, 200, 160, 300, 170);
            g.DrawRectangle(p, 270, 270,30 ,60 );
            g.DrawRectangle(p, 240, 210, 30, 30);
            g.DrawRectangle(p, 320, 210, 30, 30);
            for(int i=0;i<20;i++)
            {
                g.DrawLine(p, 210+i*10, 160, 260+i*10, 90);
            }
            Point []mas =new Point[4];
            mas[0] = new Point(350,90);
            mas[1] = new Point(450, 90);
            mas[2] = new Point(500, 160);
            mas[3] = new Point(400, 160);
            SolidBrush B = new SolidBrush(Color.White);
            g.FillPolygon(B, mas);
            for (int i = 0; i < 9; i++)
            {
                g.DrawLine(p, (float)(350+50/8*i), (float)(90+70/8*i), (float)(450 + 50 / 8 * i), (float)(90 + 70 / 8 * i));
            }
            g.DrawLine(p, 255, 210, 255, 240);
            g.DrawLine(p, 240, 225, 270, 225);
            g.DrawLine(p, 335, 210, 335, 240);
            g.DrawLine(p, 320, 225, 350, 225);
            for(int i = 0; i < 7; i++)
            {
                Rectangle rect = new Rectangle(100-i*7, 50-7*i, 500+i*14, 560+14*i);
                g.DrawArc(p, rect, 180, 180);
            }
            Rectangle rect1 = new Rectangle(0, 330, 800,270);
            g.FillRectangle(Brushes.Green, rect1);
            Rectangle rect2 = new Rectangle(350, 410, 350, 110);
            g.FillEllipse(Brushes.LightBlue, rect2);
            Rectangle rect3 = new Rectangle(270, 440, 10, 30);
            g.FillRectangle(Brushes.Brown, rect3);
            Rectangle rect4 = new Rectangle(260, 435, 30, 20);
            g.FillPie(Brushes.Brown, rect4, 180, 180);

            Rectangle rect5 = new Rectangle(180, 390, 10, 30);
            g.FillRectangle(Brushes.Brown, rect5);
            Rectangle rect6 = new Rectangle(170, 385, 30, 20);
            g.FillPie(Brushes.Brown, rect6, 180, 180);

            Rectangle rect7 = new Rectangle(700, 360, 10, 30);
            g.FillRectangle(Brushes.Brown, rect7);
            Rectangle rect8 = new Rectangle(690, 355, 30, 20);
            g.FillPie(Brushes.Brown, rect8, 180, 180);
        
            Rectangle rect9 = new Rectangle(120, 480, 60, 25);
            g.FillEllipse(Brushes.Yellow, rect9);

            Rectangle rect10 = new Rectangle(175, 477, 20, 20);
            g.FillEllipse(Brushes.Yellow, rect10);

            Point[] mas1 = new Point[3];
            mas1[0] = new Point(194, 480);
            mas1[1] = new Point(199, 486);
            mas1[2] = new Point(194, 492);
            SolidBrush BR = new SolidBrush(Color.Orange);
            g.FillPolygon(BR, mas1);
            Rectangle rect11 = new Rectangle(184, 486, 4, 4);
            g.FillEllipse(Brushes.Black, rect11);
            g.DrawLine(p, 138, 505, 138, 515);
            g.DrawLine(p, 150, 505, 150, 515);
            g.DrawLine(p, 134, 518, 138, 515);
            g.DrawLine(p, 138, 515, 142, 518);
            g.DrawLine(p, 146, 518, 150, 515);
            g.DrawLine(p, 150, 515, 154, 518);

            Rectangle rect111 = new Rectangle(500, 360, 60, 25);
            g.FillEllipse(Brushes.Yellow, rect111);

            Rectangle rect12 = new Rectangle(555, 357, 20, 20);
            g.FillEllipse(Brushes.Yellow, rect12);

            Point[] mas2 = new Point[3];
            mas2[0] = new Point(574, 360);
            mas2[1] = new Point(579, 366);
            mas2[2] = new Point(574, 372);
            g.FillPolygon(BR, mas2);

            Rectangle rect13 = new Rectangle(564, 366, 4, 4);
            g.FillEllipse(Brushes.Black, rect13);
            g.DrawLine(p, 518, 385, 518, 395);
            g.DrawLine(p, 530, 385, 530, 395);

            g.DrawLine(p, 514, 398, 518, 395);
            g.DrawLine(p, 518, 395, 522, 398);
            g.DrawLine(p, 526, 398, 530, 395);
            g.DrawLine(p, 530, 395, 534, 398);

            Rectangle rect14 = new Rectangle(700, -100, 200, 200);
            g.DrawEllipse(p, rect14);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            for (int i = 0; i < 6; i++)
            {
                g.DrawLine(p, 701+i*15, (float)(Math.Sqrt(10000 - (99-i*15) * (99-i*15))), 641+i*18, (float)(Math.Sqrt(10000 - (99 - i * 15) * (99 - i * 15)) + 45+i+3));             
            }
            g.DrawLine(p, 705, (float)(Math.Sqrt(10000 - 95 * 95)), 645, (float)(Math.Sqrt(10000 - 95 * 95)+51));
        }
    }
}
