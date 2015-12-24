using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _1224.多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行这个方法
            th = new Thread(Test);
            //th.Start();//标记这个线程准备就绪了，可以随时被执行,由cpu决定什么时候执行这个程序
            
            //将线程设置为后台线程
            th.IsBackground = true;

            th.Start();

            
        }
        public void Test()
        {
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(i);
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你点击关闭窗体的时候判断新线程是否为Null
            if (this!=null)
            {
                th.Abort();
            }
        }
    }
}
