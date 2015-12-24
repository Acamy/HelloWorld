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
        //string[] path = Directory.GetFiles(@"E:\Pictures");
        private void Form1_Load(object sender, EventArgs e)
        {


            //for (int i = 0; i < path.Length; i++)
            //{
            //    string name = Path.GetFileName(path[i]);
            //    listBox1.Items.Add(name);
            //}

        }
        string[] path=new string[0];
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (path.Length == 0)
            {
                return;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(path[listBox1.SelectedIndex]);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你需要的文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"E:\Pictures";
            ofd.Filter = "图片文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径
            path= ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (path.Length == 0)
            {
                return;
            }
            int index = listBox1.SelectedIndex;
            index++;

            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            pictureBox1.Image = Image.FromFile(path[index]);
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (path.Length == 0)
            {
                return;
            }
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index;
            pictureBox1.Image = Image.FromFile(path[index]);
        }
    }
}
