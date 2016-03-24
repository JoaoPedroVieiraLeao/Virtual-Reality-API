using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VRA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // packed hashgl.
            HashGL.pixelpanel p = new HashGL.pixelpanel();
            p.width = 100;
            p.height = 200;
            p.x = pictureBox1.Width / 2;
            p.y = pictureBox1.Height / 2;
            p.z = pictureBox1.Width / 2;
            p.width2 = 1000;
            p.cred = Color.Red;
            p.pic = pictureBox1;
            p.draw();
        }
    }
}
