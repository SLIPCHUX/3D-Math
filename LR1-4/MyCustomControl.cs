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
    public partial class MyCustomControl : UserControl
    {
        Picture p;
        public MyCustomControl()
        {
            InitializeComponent();
            p = new Picture();
            p.Fill(checkedListBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Move(i, 0, 3);
                }
            }
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Move(i, -3, 0);
                }
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Move(i, 0, -3);
                }
            }
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Move(i, 3, 0);
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            p.Draw(e.Graphics);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Rotate(i, 10);
                }
            }
            pictureBox1.Refresh();
        }

        private void MyCustomControl_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Rotate(i, -10);
                }
            }
            pictureBox1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Scale(i, 0.8, 1);
                }
            }
            pictureBox1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Scale(i, 1.2, 1);
                }
            }
            pictureBox1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Scale(i, 1, 0.8);
                }
            }
            pictureBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    p.Scale(i, 1, 1.2);
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = Convert.ToInt32(e.X);
            int y = Convert.ToInt32(e.Y);
            textBox1.Text = Convert.ToString(x);
            textBox2.Text = Convert.ToString(y);
            p.SetCentr(x, y);
            pictureBox1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
