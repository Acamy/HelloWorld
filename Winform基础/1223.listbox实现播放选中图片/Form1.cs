using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1223.listbox实现播放选中图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path = Directory.GetFiles(@"E:\Pictures");
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < path.Length; i++)
            {
                string name=Path.GetFileName(path[i]);
                listBox1.Items.Add(name);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
        }
    }
}
