using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace LR1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            myCustomControl1.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
           thirdCustomControl1.BringToFront();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            fourthCustomControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/slipchux");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.instagram.com/slipchux/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/slipchuk");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3 ThirdForm = new Form3();
            ThirdForm.Show();
        }
    }
}
