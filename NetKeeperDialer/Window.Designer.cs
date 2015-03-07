namespace iWay.NetKeeperDialer
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNkAcc = new System.Windows.Forms.TextBox();
            this.txtNkPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioRouter = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.txtRtAcc = new System.Windows.Forms.TextBox();
            this.txtRtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRtPsw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLcCnn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lnkHelp = new System.Windows.Forms.LinkLabel();
            this.cbxAuto = new System.Windows.Forms.CheckBox();
            this.checker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "闪讯账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "闪讯密码：";
            // 
            // txtNkAcc
            // 
            this.txtNkAcc.Location = new System.Drawing.Point(86, 12);
            this.txtNkAcc.Name = "txtNkAcc";
            this.txtNkAcc.Size = new System.Drawing.Size(168, 23);
            this.txtNkAcc.TabIndex = 2;
            // 
            // txtNkPsw
            // 
            this.txtNkPsw.Location = new System.Drawing.Point(86, 41);
            this.txtNkPsw.Name = "txtNkPsw";
            this.txtNkPsw.Size = new System.Drawing.Size(168, 23);
            this.txtNkPsw.TabIndex = 3;
            this.txtNkPsw.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(260, 11);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 53);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radioRouter
            // 
            this.radioRouter.AutoSize = true;
            this.radioRouter.Checked = true;
            this.radioRouter.Location = new System.Drawing.Point(15, 70);
            this.radioRouter.Name = "radioRouter";
            this.radioRouter.Size = new System.Drawing.Size(86, 21);
            this.radioRouter.TabIndex = 5;
            this.radioRouter.TabStop = true;
            this.radioRouter.Text = "路由器登录";
            this.radioRouter.UseVisualStyleBackColor = true;
            this.radioRouter.CheckedChanged += new System.EventHandler(this.radioRouter_CheckedChanged);
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(107, 70);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(98, 21);
            this.radioLocal.TabIndex = 6;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "本地直接登录";
            this.radioLocal.UseVisualStyleBackColor = true;
            this.radioLocal.CheckedChanged += new System.EventHandler(this.radioLocal_CheckedChanged);
            // 
            // txtRtAcc
            // 
            this.txtRtAcc.Location = new System.Drawing.Point(86, 126);
            this.txtRtAcc.Name = "txtRtAcc";
            this.txtRtAcc.Size = new System.Drawing.Size(168, 23);
            this.txtRtAcc.TabIndex = 10;
            this.txtRtAcc.Text = "admin";
            // 
            // txtRtIp
            // 
            this.txtRtIp.Location = new System.Drawing.Point(86, 97);
            this.txtRtIp.Name = "txtRtIp";
            this.txtRtIp.Size = new System.Drawing.Size(168, 23);
            this.txtRtIp.TabIndex = 9;
            this.txtRtIp.Text = "192.168.1.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "路由器账号：：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "路由器IP：";
            // 
            // txtRtPsw
            // 
            this.txtRtPsw.Location = new System.Drawing.Point(86, 155);
            this.txtRtPsw.Name = "txtRtPsw";
            this.txtRtPsw.Size = new System.Drawing.Size(168, 23);
            this.txtRtPsw.TabIndex = 12;
            this.txtRtPsw.Text = "admin";
            this.txtRtPsw.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "路由器密码：";
            // 
            // txtLcCnn
            // 
            this.txtLcCnn.Location = new System.Drawing.Point(86, 97);
            this.txtLcCnn.Name = "txtLcCnn";
            this.txtLcCnn.Size = new System.Drawing.Size(168, 23);
            this.txtLcCnn.TabIndex = 14;
            this.txtLcCnn.Text = "ChinaNetSNWide";
            this.txtLcCnn.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "连接名：";
            this.label6.Visible = false;
            // 
            // lnkHelp
            // 
            this.lnkHelp.AutoSize = true;
            this.lnkHelp.Location = new System.Drawing.Point(282, 100);
            this.lnkHelp.Name = "lnkHelp";
            this.lnkHelp.Size = new System.Drawing.Size(56, 17);
            this.lnkHelp.TabIndex = 15;
            this.lnkHelp.TabStop = true;
            this.lnkHelp.Text = "查看帮助";
            this.lnkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHelp_LinkClicked);
            // 
            // cbxAuto
            // 
            this.cbxAuto.AutoSize = true;
            this.cbxAuto.Location = new System.Drawing.Point(242, 71);
            this.cbxAuto.Name = "cbxAuto";
            this.cbxAuto.Size = new System.Drawing.Size(99, 21);
            this.cbxAuto.TabIndex = 16;
            this.cbxAuto.Text = "开机自动登录";
            this.cbxAuto.UseVisualStyleBackColor = true;
            this.cbxAuto.CheckedChanged += new System.EventHandler(this.cbxAuto_CheckedChanged);
            // 
            // checker
            // 
            this.checker.Enabled = true;
            this.checker.Tick += new System.EventHandler(this.checker_Tick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 189);
            this.Controls.Add(this.cbxAuto);
            this.Controls.Add(this.lnkHelp);
            this.Controls.Add(this.txtRtPsw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRtAcc);
            this.Controls.Add(this.txtRtIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioLocal);
            this.Controls.Add(this.radioRouter);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtNkPsw);
            this.Controls.Add(this.txtNkAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLcCnn);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetKeeperDialer - Designed by iWay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.this_FormClosing);
            this.Load += new System.EventHandler(this.this_FormLoad);
            this.Shown += new System.EventHandler(this.this_FormShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNkAcc;
        private System.Windows.Forms.TextBox txtNkPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioRouter;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.TextBox txtRtAcc;
        private System.Windows.Forms.TextBox txtRtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRtPsw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLcCnn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lnkHelp;
        private System.Windows.Forms.CheckBox cbxAuto;
        private System.Windows.Forms.Timer checker;
    }
}

