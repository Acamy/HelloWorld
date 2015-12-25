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
            this.textServer = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(59, 36);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(114, 21);
            this.textServer.TabIndex = 0;
            this.textServer.Text = "115.156.139.115";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(179, 35);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(52, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "8080";
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(266, 32);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(58, 27);
            this.btnConnect1.TabIndex = 2;
            this.btnConnect1.Text = "连接";
            this.btnConnect1.UseVisualStyleBackColor = true;
            this.btnConnect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(58, 69);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(477, 154);
            this.textLog.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(58, 236);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(476, 99);
            this.textMsg.TabIndex = 4;
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(448, 348);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(85, 24);
            this.btnSend2.TabIndex = 5;
            this.btnSend2.Text = "发送";
            this.btnSend2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(587, 396);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.btnConnect1);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Name = "Form1";
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
    }
}

