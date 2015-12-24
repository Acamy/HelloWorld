using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace _1224.记事本儿应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            tbx.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        List<string> list=new List<string>();
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title="请选择要打开的文本文件";
            ofd.InitialDirectory = @"C:\Users\Acamy\Desktop";
            ofd.Multiselect = true;
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";//dsa
            ofd.ShowDialog();


            string path = ofd.FileName;
            list.Add(path);
            string fileName = Path.GetFileName(path);
            listBox1.Items.Add(fileName);
            if (path=="")
            {
                return;
            }
            using (FileStream fsRead=new FileStream(path,FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r=fsRead .Read(buffer,0,buffer.Length);
                tbx.Text = Encoding.Default.GetString(buffer,0,r);
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\Acamy\Desktop";
            sfd.Title = "请选择要保存的文件路径！";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path=="")
            {
                return;
            }
            using (FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(tbx.Text);
                fsWrite.Write(buffer,0,buffer.Length);
            }
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自动换行ToolStripMenuItem.Text=="☆自动换行")
            {
                tbx.WordWrap = true;
                自动换行ToolStripMenuItem.Text="☆取消自动换行";
            }
            else if (自动换行ToolStripMenuItem.Text == "☆取消自动换行")
	        {
                tbx.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "☆自动换行";
	        }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            tbx.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            tbx.ForeColor = cd.Color;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //获得双击文件所对应的全路径
            string path = list[listBox1.SelectedIndex];
            using(FileStream fsRead=new FileStream(path,FileMode.Open,FileAccess.Read))
	         {
               
                byte[] buffer=new byte[1024*1024*5];
                int r=fsRead.Read(buffer,0,buffer.Length);
                tbx.Text=Encoding.Default.GetString(buffer,0,r);
	         }
        }
    }
}
