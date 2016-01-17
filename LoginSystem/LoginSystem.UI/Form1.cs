using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LoginSystem.BLL;

namespace LoginSystem.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtName = this.txtName.Text.Trim();
            string txtPwd = this.txtPwd.Text;
            if (CheckUserInfo(txtName,txtPwd))
            {
                UserInfoBLL bll = new UserInfoBLL();
                string msg = string.Empty;
                if (bll.UserLogin(txtName,txtPwd,out msg))
                {
                    MessageBox.Show(msg);
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }
        private bool CheckUserInfo(string txtName,string txtPwd)
        {
            if (string.IsNullOrEmpty(txtName))
            {
                MessageBox.Show("用户名不能为空！！");
                return false;
            }
            if (string.IsNullOrEmpty(txtPwd))
            {
                MessageBox.Show("密码不能为空！！");
                return false;
            }
            return true;
        }
    }
}
