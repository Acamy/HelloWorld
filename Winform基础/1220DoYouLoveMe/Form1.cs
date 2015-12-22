using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoYouLoveMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("你爱我吗？");
        }
        /// <summary>
        /// 当鼠标进入按钮的可见部分的时候，给按钮一个新的位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是 窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random r = new Random();
            //要给按钮一个随机的坐标
            button2.Location = new Point(r.Next(0,x+1),r.Next(y+1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟思密哒");
            this.Close();//关闭主窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你点到了");
        }
    }
}
