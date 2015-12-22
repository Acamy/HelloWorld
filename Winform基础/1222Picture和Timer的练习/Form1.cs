using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Picture和Timer的练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        string[] path = Directory.GetFiles(@"E:\Pictures");
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"E:\KuGou\严艺丹 - 无果.wav";
            sp.Play();
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length-1)]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox2.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
           
            pictureBox3.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox4.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox5.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox6.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox7.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
           
            pictureBox8.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
            pictureBox9.Image = Image.FromFile(path[r.Next(0, path.Length - 1)]);
            
        }
    }
}
