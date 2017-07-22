using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Space
{
    public class SolarSystem
    {
        public int x;
        public int y;
        double A = 0;
        double B = 0;
        double C = 0;
        double D = 0;
        public Panel panelm;
        public Panel panelv;
        public Panel panelz;
        public Panel panelmr;
        public SolarSystem()
        {
            x = 0;
            y = 0;
            panelm = new Panel();
            panelv = new Panel();
            panelz = new Panel();
            panelmr = new Panel();
        }
        public void Circle(Graphics g, int X, int Y)
        {
            Pen p = new Pen(Brushes.Gray, 1);
            Rectangle rect1 = new Rectangle(X - 55 + x, Y - 55 + y, 110, 110);
            Rectangle rect2 = new Rectangle(X - 90 + x, Y - 90 + y, 180, 180);
            Rectangle rect3 = new Rectangle(X - 150 + x, Y - 150 + y, 300, 300);
            Rectangle rect4 = new Rectangle(X - 200 + x, Y - 200 + y, 400, 400);

            g.DrawEllipse(p, rect1);
            g.DrawEllipse(p, rect2);
            g.DrawEllipse(p, rect3);
            g.DrawEllipse(p, rect4);

            g.DrawImage(Properties.Resources.sun, X - 30 + x, Y - 30 + y);
        }

        public void MovePlanets(Graphics g, int width, int height)
        {
            int x = (int)(55 * Math.Cos(A) + (width >> 1) - 13) + this.x;
            int y = (int)(55 * Math.Sin(A) + (height >> 1) - 13) + this.y;
            panelm.Location = new Point(x, y);
            A += 0.06;
            x = (int)(90 * Math.Cos(B) + (width >> 1) - 13) + this.x;
            y = (int)(90 * Math.Sin(B) + (height >> 1) - 13) + this.y;
            panelv.Location = new Point(x, y);
            B += 0.03;
            x = (int)(150 * Math.Cos(C) + (width >> 1) - 13) + this.x;
            y = (int)(150 * Math.Sin(C) + (height >> 1) - 13) + this.y;
            panelz.Location = new Point(x, y);
            C += 0.07;
            x = (int)(200 * Math.Cos(D) + (width >> 1) - 13) + this.x;
            y = (int)(200 * Math.Sin(D) + (height >> 1) - 13) + this.y;
            panelmr.Location = new Point(x, y);
            D += 0.04;
        }
    }
}
