using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace LR1_4
{
    public class Element
    {
        protected string name;
        protected PointF[] points;
        Pen pen = new Pen(Color.White, 2);
        public void Draw(Graphics g)
        {
            g.DrawLines(pen, points);
        }
        public string GetName()
        {
            return name;
        }

        internal void Move(int dX, int dY)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += (float)dX;
                points[i].Y += (float)dY;
            }
        }

        internal void Scale(double kX, double kY)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X *= (float)kX;
                points[i].Y *= (float)kY;
            }
        }

        internal void Rotate(int angle)
        {
            double a = angle * Math.PI / 180.0;
            for (int i = 0; i < points.Length; i++)
            {
                float x = points[i].X;
                float y = points[i].Y;
                points[i].X = (float)(x * Math.Cos(a) - y * Math.Sin(a));
                points[i].Y = (float)(x * Math.Sin(a) + y * Math.Cos(a));
            }
        }
    };
    public class Triangle : Element
    {
        public Triangle(string _name, PointF p1, PointF p2, PointF p3)
        {
            points = new PointF[4];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p1;
            name = _name;
        }
    };
    public class Square : Element
    {
        public Square(string _name, PointF p1, PointF p2, PointF p3, PointF p4)
        {
            points = new PointF[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p1;
            name = _name;
        }
    };
    public class Circle : Element
    {
        public Circle(string _name, double CentrX, double CentrY, double Height, double Width)
        {
            name = _name;
            points = new PointF[101];
            int k = 0;
            for (double i = 0.0; i < 2.0 * Math.PI && k < 100; i += 2.0 * Math.PI / 100.0, k++)
            {
                points[k].X = (float)(Width * Math.Cos(i) + CentrX);
                points[k].Y = (float)(Height * Math.Sin(i) + CentrY);
            }
            points[100] = points[0];
        }
    };
    public class Lines : Element
    {
        public Lines(string _name, PointF p1, PointF p2)
        {
            points = new PointF[2];
            points[0] = p1;
            points[1] = p2;
            name = _name;
        }
    };
    public class Mouth : Element
    {
        public Mouth(string _name, PointF p1, PointF p2, PointF p3, PointF p4, PointF p5)
        {
            points = new PointF[5];
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
            points[3] = p4;
            points[4] = p5;
            name = _name;
        }
    };
    public class Picture
    {
        Element[] items;
        private int cX;
        private int cY;

        public Picture()
        {
            items = new Element[17];
            items[0] = new Square("Left Flue", new PointF(110, 50), new PointF(160, 50), new PointF(160, 140), new PointF(110, 140));
            items[1] = new Square("Right Flue", new PointF(310, 50), new PointF(360, 50), new PointF(360, 140), new PointF(310, 140));
            items[2] = new Square("Wheel-House", new PointF(70, 140), new PointF(400, 140), new PointF(400, 250), new PointF(70, 250));
            items[3] = new Square("Deck", new PointF(10, 250), new PointF(460, 250), new PointF(360, 380), new PointF(110, 380));
            items[4] = new Circle("1 Eluminator", 110, 180, 20, 20);
            items[5] = new Circle("2 Eluminator", 190, 180, 20, 20);
            items[6] = new Circle("3 Eluminator", 270, 180, 20, 20);
            items[7] = new Circle("4 Eluminator", 350, 180, 20, 20);
            items[8] = new Triangle("Shark", new PointF(500, 400), new PointF(480, 350), new PointF(560, 410));
            items[9] = new Lines("1 Stairs", new PointF(180, 250), new PointF(180, 380));
            items[10] = new Lines("2 Stairs", new PointF(210, 250), new PointF(210, 380));
            items[11] = new Lines("3 Stairs", new PointF(180, 280), new PointF(210, 280));
            items[12] = new Lines("4 Stairs", new PointF(180, 320), new PointF(210, 320));
            items[13] = new Lines("5 Stairs", new PointF(180, 360), new PointF(210, 360));
            items[14] = new Lines("Flagstaff", new PointF(435, 140), new PointF(435, 250));
            items[15] = new Triangle("Flag", new PointF(435, 140), new PointF(500, 120), new PointF(435, 100));
            items[16] = new Lines("Flag's line", new PointF(435, 120), new PointF(500, 120));
        }
        public void Draw(Graphics g)
        {
            foreach (Element e in items)
            {
                e.Draw(g);
            }
            g.DrawEllipse(Pens.Green, cX, cY, 4, 4);
        }

        public void Fill(CheckedListBox checkedListBox1)
        {
            foreach (Element e in items)
            {
                checkedListBox1.Items.Add(e.GetName());
            }
        }

        internal void Move(int i, int dX, int dY)
        {
            items[i].Move(dX, dY);
        }
        public void SetCentr(int X, int Y)
        {
            cX = X;
            cY = Y;
        }

        internal void Scale(int i, double kX, double kY)
        {
            items[i].Move(-cX, -cY);
            items[i].Scale(kX, kY);
            items[i].Move(cX, cY);
        }

        internal void Rotate(int i, int angle)
        {
            items[i].Move(-cX, -cY);
            items[i].Rotate(angle);
            items[i].Move(cX, cY);
        }
    };
}
