using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _1221_记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.WordWrap = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string pwd = textBox2.Text;
            if (name=="admin"&&pwd=="888888")
            {
                MessageBox.Show("登录成功！");

                button3.Visible = true;
                button4.Visible = true;
                textBox3.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button5.Visible = false;
                textBox3.Focus();
            }
            else
            {
                MessageBox.Show("登录失败！请重新输入！");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox3.WordWrap = !textBox3.WordWrap;
            if (textBox3.WordWrap == true)
            {
                button3.Text = "取消自动换行";
                
            }
            else
            {
                button3.Text = "自动换行";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream(@"C:\Users\Acamy\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox3.Text.Trim());
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("用户名：admin,密码：888888");
        }
    }
}
