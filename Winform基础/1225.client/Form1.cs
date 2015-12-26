using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _1225.client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        Socket socketSend;
        private void btnConnect1_Click(object sender, EventArgs e)
        {
            Connect();
            
        }
        

        void Receive()
        {
                while (true)
                {
                    try
                    {
                    byte[] buffer = new byte[1024 * 1024 * 3];

                    //实际接收到的有效字节
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //表示发送的是文字消息
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(txtInfo .Text +" "+DateTime.Now.ToString()+ ":\r\n  " + s);
                    }
                    //表示发送的是文件
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = @"E:\";
                        sfd.Title = "请选择要保存的文件";
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);

                        string path = sfd.FileName;
                        using (FileStream fsWrite=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");

                    }
                    //表示发送的是震动
                    else if (buffer[0] == 2)
                    {
                        ZD();
                    }




                }

                catch
                {}
            }
        }
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {

                this.Location = new Point(this.Location.X - 3, this.Location.Y - 3);
                this.Location = new Point(this.Location.X + 6, this.Location.Y + 6);
                this.Location = new Point(this.Location.X - 3, this.Location.Y - 3);
            }
        }
        void ShowMsg(string str)
        {
            textLog.AppendText(str+"\r\n");
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            try
            {
                
                string str = textMsg.Text.Trim();                
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                
                socketSend.Send(buffer);
                ShowMsg(txtName.Text + " " + DateTime.Now.ToString() + ":\r\n  " + str);
                textMsg.Clear();
                textMsg.Focus();
            }
            catch 
            {
                MessageBox.Show("发送失败，请确保服务器开户！");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            textMsg.Select();
            Connect();
        }

        private void Connect()
        {
            try
            {
                //创建负责通信的socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(textServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textPort.Text));
                //获得要连接的远程服务器应用程序的IP地址和端口号
                socketSend.Connect(point);
                ShowMsg(DateTime.Now.ToString() + ":连接到" + socketSend.RemoteEndPoint + "成功！");

                //开启一个新的线程不停的接收服务器发来的消息
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start();
            }
            catch
            {
                MessageBox.Show("请先开户服务器！");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                btnSend2_Click(sender, e);
            }
        }
        private void textMsg_KeyDown(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的路径";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";

            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textLog.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功！");
        }

    }
}
