using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LR1_4
{
    public partial class Form3 : Form
    {
       SoundPlayer player;
        bool playing = false;
        public Form3()
        {
            InitializeComponent();
            player = new SoundPlayer();
            player.SoundLocation = "Gimn.wav";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                player.Play();
                playing = true;
            }
            else
            {
                player.Stop();
                playing = false;
            }
        }
    }
}
