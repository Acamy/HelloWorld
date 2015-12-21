using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace _1221跑马灯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒了！关不掉了吧，哈哈");
            
            label2.Text=label2.Text.Substring(1) + label2.Text.Substring(0,1);
        }
        /// <summary>
        /// 当窗体加载的时候，将当前的时间赋值给Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Text = DateTime.Now.ToString();
        }
        /// <summary>
        /// 每隔一秒钟就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text=DateTime.Now.ToString();
            //指定时间播放音乐
            if (DateTime.Now.Hour==10&&DateTime.Now.Minute==28&&DateTime.Now.Second==0)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"E:\KuGou\严艺丹 - 无果.wav";
                sp.Play();
                //sp.Stop();
            }
        }

        SoundPlayer s = new SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {

           timer1.Start();
           s.SoundLocation = @"严艺丹 - 无果.wav";
           s.Play();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.Stop();
            timer1.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
