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

namespace socket_是否连接
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ip = IPAddress.Any;
            IPAddress ip = IPAddress.Parse("115.156.139.115");
            //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32("8080"));
            //监听  目的：等待客户端连接过来
            socket.Bind(point);
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        } 
    }
}
