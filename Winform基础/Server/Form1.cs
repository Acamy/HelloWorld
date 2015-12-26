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


namespace Server
{


    
    public partial class Form1 : Form
    {
        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        DialogResult r = MessageBox.Show("确定要退出程序?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (r != DialogResult.OK)
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //}
        bool b = false;
        string log = @"E:\Log.txt";
        public Form1()
        {
            InitializeComponent();
        }
        Icon ic_1 = new Icon(@"E:\Pictures\exe.ico");
        Icon ic_2 = new Icon(@"E:\Pictures\touming.ico");
        public void ss()
        {
            //while (b)
            //{
                
            //}
        }
           
        
        private void btnStart_Click(object sender, EventArgs e)
        {

            Listen1();       
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //e.Cancel = true;
            //object sender=1;
            ////EventArgs e;
            //btnHide_Click(sender, e);
            
                DialogResult r = MessageBox.Show("确定要退出程序?选择取消退出最小化到通知栏！", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r != DialogResult.OK)
                {
                    e.Cancel = true;
                    if (this.Visible == true) this.Visible = false;//假如当前窗口为显示的则隐藏窗口
                }
            
        }

        private void Listen1()
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
                using (StreamWriter sw = new StreamWriter(log, true))
                {
                    sw.WriteLine("监听成功");
                }
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch
            { }
        }
        Socket socketSend;
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
                    socketSend = socketWatch.Accept();
                    //将用户的IP地址和socket存到键值对中
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(),socketSend);
                    //将远程连接发客户端IP地址和端口号存储下拉框中
                    cboUser.Items.Add(socketSend.RemoteEndPoint.ToString());
                    cboUser.SelectedItem = socketSend.RemoteEndPoint.ToString();
                    //115.156.139.115：连接成功
                    ShowMsg(DateTime.Now.ToString() + " "+socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    using (StreamWriter sw = new StreamWriter(log, true))
                    {
                        sw.WriteLine(DateTime.Now.ToString() + " " + socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                    }
                    //开户一个新线程不停的接受客户端发送过来的消息
                    Thread th = new Thread(Receive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch 
                {}
                
            }
            
        }
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
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
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    //表示实际接收到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + DateTime.Now.ToString()+":\r\n" +"   "+str);
                    using (StreamWriter sw = new StreamWriter(log, true))
                    {
                        sw.WriteLine(socketSend.RemoteEndPoint + DateTime.Now.ToString() + ":\r\n" + "   " + str);
                    }
                }
                catch 
                {}               
                
            }
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str+"\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;
            txtMessage.Select();
            Listen1();

        }
        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                
                string str = txtMessage.Text;
                
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                //将泛型集合转换为数组
                byte[] newBuffer=list.ToArray();
                //获得用户在下拉框中选中的IP地址
                string ip = cboUser.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer);
                ShowMsg("Server " + DateTime.Now.ToString() + ":\r\n" + "   " + str);
                using (StreamWriter sw = new StreamWriter(log, true))
                {
                    sw.WriteLine("Server " + DateTime.Now.ToString() + ":\r\n" + "   " + str);
                }
                txtMessage.Clear();
                txtMessage.Focus();
            }
            catch 
            {
                MessageBox.Show("没有用户连接服务器！");
            }
            
        }
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\Acamy\Desktop";
            ofd.Title="请选择要发送的文件";
            ofd.Filter="所有文件|*.*";
            ofd.ShowDialog();

            txtPath.Text= ofd.FileName;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //获得要发送文件的路径
                string path = txtPath.Text;
                using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    List<byte> list = new List<byte>();
                    list.Add(1);
                    list.AddRange(buffer);
                    byte[] newBuffer = list.ToArray();                    
                    dicSocket[cboUser.SelectedItem.ToString()].Send(newBuffer, 0, r+1, SocketFlags.None);
                }
            }
            catch 
            { }
            
        }
        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[cboUser.SelectedItem.ToString()].Send(buffer);
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnSend_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的路径";
            sfd.InitialDirectory = @"C:\Users\Acamy\Desktop";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";

            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(txtLog.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功！");
        }
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            notifyIcon1.Icon = ic_1;
            b = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Visible==false)
            {
               
            if (b)        //ICO来回切换，实现ICO闪烁功能
            {
                notifyIcon1.Icon = ic_1;
                //notifyIcon1.Icon = ic_2;
                b = false;
            }
            else
            {
                notifyIcon1.Icon = ic_2;
                b = true;
            }

            }
            else
            {
                timer1.Enabled = false;
            }
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Acamy\Desktop\Log.txt", true))
            {
                byte[] buffer = Encoding.Default.GetBytes(txtLog.Text);
                sw.WriteLine(txtLog.Text);
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            b = true;
            //ss();
            
        }


        private void btnHide_Click(object sender, EventArgs e)
        {
            
            if (this.Visible == true) this.Visible = false;//假如当前窗口为显示的则隐藏窗口  

        }

       

        private void btnHide_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//窗体状态为最小化 
            {
                //this.Visible = false;
                //this.notifyIcon1.Visible = true; //显示系统托盘图标 
                //this.notifyIcon1.Text = this.Text; //设置图标显示的文本 
                //this.ShowInTaskbar = false; //窗体在任务标中隐藏
                
                btnHide_Click(sender, e);
            }
            
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false ;
            b = false;
            if (this.Visible == false)
                this.Visible = true;//假如当前窗口没显示则显示当前窗口
            //this
        }

        //private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            b = false;
            if (this.Visible == false)
                this.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            b = false;
            if (this.Visible == false)
                this.Visible = true;
        }
       
       
    }
}
