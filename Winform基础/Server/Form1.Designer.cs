namespace Server
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Exit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(70, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(167, 21);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "115.156.139.115";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(245, 40);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "8080";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(372, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = " 开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(504, 42);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(145, 20);
            this.cboUser.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(72, 72);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(576, 204);
            this.txtLog.TabIndex = 4;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMessage.Location = new System.Drawing.Point(70, 306);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(578, 120);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(69, 457);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(438, 21);
            this.txtPath.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "发送文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(376, 495);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(474, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "震动";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "保存聊天记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(669, 497);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 12;
            this.btnHide.Text = "隐藏窗体";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.Resize += new System.EventHandler(this.btnHide_Resize);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Exit;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Server";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Exit
            // 
            this.Exit.Name = "contextMenuStrip1";
            this.Exit.Size = new System.Drawing.Size(61, 4);
            this.Exit.Text = " 退出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 528);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "何氏实时聊天通讯智能客户端1.0(Server 版)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip Exit;
    }
}

