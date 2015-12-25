using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候，在服务器端创建一个负责监IP地址跟端口号的socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //监听  目的：等待客户端连接过来
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch 
            {
                               
            }                       
        }
        /// <summary>
        /// 等待客户端的连接，并且创建与这通信用的socket
        /// </summary>
        /// <param name="o"></param>
        void Listen(Object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端的连接，并且创建一个负责通信用的socket
            while (true)
            {
                try
                {
                    //等待客户端的连接，并且创建与这通信用的socket
                    Socket socketSend = socketWatch.Accept();
                    //115.156.139.115：连接成功
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    //开户一个新线程不停的接受客户端发送过来的消息

                    Thread th = new Thread(Receive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch 
                {
                   
                }
                
            }
            
        }
       /// <summary>
        /// 客户端不断的接受客户端发送过来的消息
       /// </summary>
       /// <param name="o"></param>
        void Receive(object o)
        {
            Socket socketSend = o as Socket;      
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch 
                {
                     throw;
                }               
                
            }
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str+"\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

       
    }
}
