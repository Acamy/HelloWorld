namespace _1225.client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textServer = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(40, 611);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(114, 21);
            this.textServer.TabIndex = 0;
            this.textServer.Text = "115.156.139.115";
            this.textServer.Visible = false;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(160, 610);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(52, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "8080";
            this.textPort.Visible = false;
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(430, 36);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(105, 27);
            this.btnConnect1.TabIndex = 2;
            this.btnConnect1.Text = "重新连接服务器";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // textLog
            // 
            this.textLog.BackColor = System.Drawing.Color.White;
            this.textLog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLog.Location = new System.Drawing.Point(23, 66);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(523, 370);
            this.textLog.TabIndex = 3;
            this.textLog.TextChanged += new System.EventHandler(this.textLog_TextChanged);
            // 
            // textMsg
            // 
            this.textMsg.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textMsg.Location = new System.Drawing.Point(23, 463);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(523, 138);
            this.textMsg.TabIndex = 4;
            this.textMsg.Text = "   欢迎您使用JoyChat实时聊天通讯智能客户端1.0版本！请在此文本框输入你想要发送的信息。";
            this.textMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMsg_KeyDown);
            // 
            // btnSend2
            // 
            this.btnSend2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSend2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend2.Location = new System.Drawing.Point(430, 608);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(80, 28);
            this.btnSend2.TabIndex = 5;
            this.btnSend2.Text = "发  送";
            this.btnSend2.UseVisualStyleBackColor = false;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入您的昵称：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 21);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Client";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(384, 9);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(70, 21);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "请输入对方备注：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "聊天记录框：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "信息输入框：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = " 保存聊天记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "JoyChat1.0";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.BalloonTipShown += new System.EventHandler(this.notifyIcon1_BalloonTipShown);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.btnConnect1);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

