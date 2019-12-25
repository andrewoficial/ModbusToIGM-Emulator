namespace WindowsFormsApp3
{
    partial class Http_Post
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SendPut = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lsendtime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.lRecievTime = new System.Windows.Forms.ToolStripLabel();
            this.rtbDataF = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdrServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdentificator = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCountLine = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(158, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(614, 222);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SendPut
            // 
            this.SendPut.Location = new System.Drawing.Point(660, 35);
            this.SendPut.Name = "SendPut";
            this.SendPut.Size = new System.Drawing.Size(112, 23);
            this.SendPut.TabIndex = 1;
            this.SendPut.Text = "Отправить запрос";
            this.SendPut.UseVisualStyleBackColor = true;
            this.SendPut.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(6, 33);
            this.tbLogin.MaxLength = 30;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(122, 20);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.Text = "demouser";
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbIdentificator_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(6, 72);
            this.tbPassword.MaxLength = 30;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(122, 20);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "demouser";
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbIdentificator_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Войти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Зарегистрироваться";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.tbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 167);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вход";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.lsendtime,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.lRecievTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel2.Text = "Время:";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(142, 22);
            this.toolStripLabel3.Text = "Время начало отправки:";
            // 
            // lsendtime
            // 
            this.lsendtime.Name = "lsendtime";
            this.lsendtime.Size = new System.Drawing.Size(76, 22);
            this.lsendtime.Text = "00:00:00:0000";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(196, 22);
            this.toolStripLabel4.Text = "Время получения полного ответа:";
            // 
            // lRecievTime
            // 
            this.lRecievTime.Name = "lRecievTime";
            this.lRecievTime.Size = new System.Drawing.Size(76, 22);
            this.lRecievTime.Text = "00:00:00:0000";
            // 
            // rtbDataF
            // 
            this.rtbDataF.Location = new System.Drawing.Point(158, 81);
            this.rtbDataF.Name = "rtbDataF";
            this.rtbDataF.Size = new System.Drawing.Size(614, 222);
            this.rtbDataF.TabIndex = 12;
            this.rtbDataF.Text = "";
            this.rtbDataF.TextChanged += new System.EventHandler(this.rtbDataF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имитация данных команды F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ответ от сервера";
            // 
            // tbAdrServer
            // 
            this.tbAdrServer.Location = new System.Drawing.Point(364, 37);
            this.tbAdrServer.Name = "tbAdrServer";
            this.tbAdrServer.Size = new System.Drawing.Size(214, 20);
            this.tbAdrServer.TabIndex = 15;
            this.tbAdrServer.Text = "http://192.168.1.190/Utilites/TestFile.php";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Адрес сервера";
            // 
            // tbIdentificator
            // 
            this.tbIdentificator.Location = new System.Drawing.Point(161, 37);
            this.tbIdentificator.MaxLength = 50;
            this.tbIdentificator.Name = "tbIdentificator";
            this.tbIdentificator.Size = new System.Drawing.Size(197, 20);
            this.tbIdentificator.TabIndex = 17;
            this.tbIdentificator.Text = "2019.12.25_16-45 #04 Sn_09501657.log";
            this.tbIdentificator.TextChanged += new System.EventHandler(this.tbIdentificator_TextChanged);
            this.tbIdentificator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbIdentificator_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "File name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Кол-во строк";
            // 
            // tbCountLine
            // 
            this.tbCountLine.Location = new System.Drawing.Point(584, 37);
            this.tbCountLine.MaxLength = 4;
            this.tbCountLine.Name = "tbCountLine";
            this.tbCountLine.Size = new System.Drawing.Size(70, 20);
            this.tbCountLine.TabIndex = 19;
            this.tbCountLine.Text = "500";
            this.tbCountLine.TextChanged += new System.EventHandler(this.tbCountLine_TextChanged);
            this.tbCountLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCountLine_KeyPress);
            // 
            // Http_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCountLine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbIdentificator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAdrServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDataF);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendPut);
            this.Controls.Add(this.richTextBox1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Http_Post";
            this.Text = "HTTP Post";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SendPut;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.RichTextBox rtbDataF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdrServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdentificator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCountLine;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lsendtime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel lRecievTime;
    }
}

