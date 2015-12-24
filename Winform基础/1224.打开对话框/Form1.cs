using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1224.打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框的标题
            ofd.Title = "请选择要打开的文本文件";//请选择要打开的文本文件
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置对话框的打开初始目录
            ofd.InitialDirectory = @"E:\pictures";
            //设置对话框的文件类型
            ofd.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|*.jpg";//所有文件｜*.*
            
            ofd.ShowDialog();
            
            //获得在打开对话框中选中文件的路径
            
            string path = ofd.FileName;
            if (path=="")
            {
                return;//立即跳出当前的方法
            }
            using (FileStream fsRead=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
            {
                //设置每次读到文件的大小为5M
                byte[] buffer=new byte[1024*1024*5];
                //获取实际读到的字节数
                int r=fsRead.Read(buffer,0,buffer.Length);
                textBox1.Text=Encoding.Default.GetString(buffer,0,r);
            }
           

        }
    }
}
