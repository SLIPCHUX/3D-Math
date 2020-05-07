using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_4
{
    public partial class FirstCustomControl : UserControl
    {
        public FirstCustomControl()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        float func(float x)
        {
            float a = float.Parse(textBox11.Text);
            float b = float.Parse(textBox22.Text);

            //float y = a * x * (float)Math.Sin(b * x);
            float y = Math.Abs(x) + a * (float)Math.Sin(b * x);
            //float y = a * Math.Abs((float)Math.Cos(b * x));
            //float y = a * (float)Math.Sqrt(x * x * x);
            return y;
        }

        float ConvertX(float x)
        {
            float x1 = float.Parse(textBox33.Text);
            float x2 = float.Parse(textBox44.Text);
            float NewX = (pictureBox1.Width * (x - x1)) / (x2 - x1);
            return NewX;
        }

        float ConvertY(float y, float minY, float maxY)
        {
            float NewY = (float)(pictureBox1.Height * (maxY - y)) / (maxY - minY);
            return NewY;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            //Graphics g = e.Graphics;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);

            Pen pen1 = new Pen(colorDialog1.Color, float.Parse(PenSize.Text));
            Pen pen2 = new Pen(colorDialog2.Color, 1);
            int pW = pictureBox1.Width, pH = pictureBox1.Height;
            float x1 = float.Parse(textBox33.Text);
            float x2 = float.Parse(textBox44.Text);
            float size = (x2 - x1) / 1000;
            float x = x1;
            float y;
            List<PointF> Point = new List<PointF>();
            float maxY = func(x1), minY = func(x1);
            while (x < x2)
            {
                y = func(x);
                if (y > maxY)
                    maxY = y;
                if (y < minY)
                    minY = y;
                x += size;
            }
            x = x1;
            while (x < x2)
            {
                y = func(x);
                Point.Add(new PointF(ConvertX(x), ConvertY(y, minY, maxY)));
                x += size;
            }
            g.DrawLines(pen1, Point.ToArray());


            Font myFont = new Font("Century Gothic", 10, FontStyle.Regular);  
            float CentrY = ConvertY(0, minY, maxY);
            float CentrX = ConvertX(0);
            if (CentrX < 0)
                CentrX = 20;
            if (CentrX > pictureBox1.Width)
                CentrX = pictureBox1.Width - 20;
            if (CentrY < 0)
                CentrY = 20;
            if (CentrY > pictureBox1.Height)
                CentrY = pictureBox1.Height - 20;
            g.DrawLine(pen2, CentrX, ConvertY(minY, minY, maxY), CentrX, ConvertY(maxY, minY, maxY));
            g.DrawLine(pen2, ConvertX(x1), CentrY, ConvertX(x2), CentrY);


            for (int i = (int)x1; i <= (int)x2; i++)
            {
                if (i != 0)
                {
                    if (comboBox1.SelectedIndex == 1)
                        g.DrawEllipse(pen2, ConvertX(i), CentrY - 3, 6, 6);
                    else if (comboBox1.SelectedIndex == 2)
                        g.DrawRectangle(pen2, ConvertX(i), CentrY - 3, 6, 6);
                    else
                        g.DrawLine(pen2, ConvertX(i), CentrY - 3, ConvertX(i), CentrY + 3);
                    g.DrawString(i.ToString(), myFont, Brushes.White, ConvertX(i), CentrY);//
                }
            }
            for (int j = (int)minY; j <= (int)maxY; j++)
            {
                if (j != 0)
                {
                    if (comboBox1.SelectedIndex == 1)
                        g.DrawEllipse(pen2, CentrX - 3, ConvertY(j, minY, maxY), 6, 6);
                    else if (comboBox1.SelectedIndex == 2)
                        g.DrawRectangle(pen2, CentrX - 3, ConvertY(j, minY, maxY), 6, 6);
                    else
                        g.DrawLine(pen2, CentrX - 3, ConvertY(j, minY, maxY), CentrX + 3, ConvertY(j, minY, maxY));
                    g.DrawString(j.ToString(), myFont, Brushes.White, CentrX, ConvertY(j, minY, maxY)); //
                }
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void SetGraphColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.Refresh();
        }

        private void SetColorAxis_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            pictureBox1.Refresh();
        }

        private void SetColorMesh_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
        }
    }
}
