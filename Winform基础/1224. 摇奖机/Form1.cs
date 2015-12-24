using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _1224.摇奖机
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
            if (b==false)
            {
                b = true;
                button1.Text = "停止";
                th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else
            {
                foreach (var item in listBox1.Items)
                {
                    if (label1.Text + label2.Text + label3.Text==item)
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                    }
                }
                b = false;
                button1.Text = "开始";
                th.Abort();
                listBox1.Items.Add(label1.Text + label2.Text + label3.Text);
                
            }
            
           
        }
        bool b = false;
        
        private void PlayGame()
        {
            Random r = new Random();
            while (b)
            {
                label1.Text = r.Next(0,10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();              
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
