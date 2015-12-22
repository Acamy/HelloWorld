using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图片上一张下一张
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path = Directory.GetFiles(@"E:\Pictures");
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i > path.Length-1)
            {
                i = 0;
            }
            i++;
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i ==0)
            {
                i = path.Length;
            }
            i--;
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"E:\Pictures\22.jpg");
        }
    }
}
