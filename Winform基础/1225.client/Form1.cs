using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _1225.client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            //创建负责通信的socket
            Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse(textServer.Text);
            IPEndPoint point = new IPEndPoint(ip,Convert.ToInt32(textPort.Text));
            //获得要连接的远程服务器应用程序的IP地址和端口号
            socketSend.Connect(point);
            ShowMsg("连接成功");
        }
        void ShowMsg(string str)
        {
            textLog.AppendText(str+"\r\n");
        }

    }
}
