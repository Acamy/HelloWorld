using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1228.绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Yanzhengma();

        }

        private void Yanzhengma()
        {
            string str = null;
            Random r = new Random();
            for (int i = 0; i < 6; i++)
            {
                str += r.Next(0, 10);
            }
            Bitmap bmp = new Bitmap(180, 40);
            Graphics g = Graphics.FromImage(bmp);
            for (int i = 0; i < 6; i++)
            {
                Point p = new Point(30 * i, 0);
                string[] fonts = { "宋体", "楷体", "仿宋", "行书", "隶书" ,"黑体","幼圆" };
                Color[] colors = { Color.Red, Color.Yellow, Color.Black, Color.Blue, Color.Gray,Color.Brown,Color.DarkSeaGreen,Color.DarkViolet,Color.AliceBlue};
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, fonts.Length)], 30, FontStyle.Bold), new SolidBrush(colors[r.Next(0, colors.Length)]), p);
            }
            for (int i = 0; i < 35; i++)
            {
                g.DrawLine(new Pen(Brushes.Green),new Point(r.Next(0,pictureBox1.Width),r.Next(0,pictureBox1.Height)),new Point(r.Next(0,pictureBox1.Width),r.Next(0,pictureBox1.Height)));
            }
            for (int i = 0; i < 500; i++)
            {
                bmp.SetPixel(r.Next(0, bmp.Width), r.Next(0, bmp.Height), Color.Blue);
            }




            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yanzhengma();
        }
    }
}
