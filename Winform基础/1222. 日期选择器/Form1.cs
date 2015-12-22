using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1222.日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通过代码给下拉框添加数据
            comboBox2.Items.Add("张三");
            comboBox2.Items.Add("李四");
            comboBox2.Items.Add("王五");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加之前应该清空之前的内容
            cbomonth.Items.Clear();
            for (int i = 1; i <=12; i++)
            {
                cbomonth.Items.Add(i + "月");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候，有一些默认的数值
            //获得当前的年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboyear.Items.Add(i+"年");
            }
        }
        /// <summary>
        /// 当月份发生改变的时候，加载天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbomonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboday.Items.Clear();
            int day = 0;
            //获得年 月
            string strMonth = cbomonth.SelectedItem.ToString().Split(new char[] {'月'})[0];
            string strYear = cboyear.SelectedItem.ToString().Split(new char[] { '年' })[0];
            int month = Convert.ToInt32(strMonth);
            int year = Convert.ToInt32(strYear);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31;
                    break;
                case 2:
                    if (year%400==0||(year%4==0&&year%100!=0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;
                    break;

            }
            for (int i = 1; i <=day; i++)
            {
                cboday.Items.Add(i+"日");
            }
        }
    }
}
