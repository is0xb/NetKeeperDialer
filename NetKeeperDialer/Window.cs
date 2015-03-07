using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace iWay.NetKeeperDialer
{
    public partial class Window : Form
    {
        public Window(bool start)
        {
            InitializeComponent();
            isAutoStart = start;
            if (isAutoStart)
            {
                this.Opacity = 0;
            }
        }

        private bool isAutoStart = false;

        private void this_FormLoad(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string myDirectory = appDataPath + "\\iWay\\NetKeeperDialer";
            string myFilepPath = myDirectory + "\\NetKeeperDialer.ini";
            if (File.Exists(myFilepPath))
            {
                try
                {
                    string[] strset = File.ReadAllLines(myFilepPath);
                    txtNkAcc.Text = strset[0];
                    txtNkPsw.Text = strset[1];
                    radioRouter.Checked = bool.Parse(strset[2]);
                    radioLocal.Checked = bool.Parse(strset[3]);
                    txtRtIp.Text = strset[4];
                    txtRtAcc.Text = strset[5];
                    txtRtPsw.Text = strset[6];
                    txtLcCnn.Text = strset[7];
                    cbxAuto.Checked = bool.Parse(strset[8]);
                }
                catch { }
            }
            btnLogin.Select();
        }

        private void this_FormShown(object sender, EventArgs e)
        {
            if (isAutoStart)
            {
                this.Hide();
                btnLogin_Click(null, null);
            }
        }

        private void this_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] strset = new string[9];
            strset[0] = txtNkAcc.Text;
            strset[1] = txtNkPsw.Text;
            strset[2] = radioRouter.Checked.ToString();
            strset[3] = radioLocal.Checked.ToString();
            strset[4] = txtRtIp.Text;
            strset[5] = txtRtAcc.Text;
            strset[6] = txtRtPsw.Text;
            strset[7] = txtLcCnn.Text;
            strset[8] = cbxAuto.Checked.ToString();
            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string myDirectory = appDataPath + "\\iWay\\NetKeeperDialer";
                string myFilepPath = myDirectory + "\\NetKeeperDialer.ini";
                Directory.CreateDirectory(myDirectory);
                File.WriteAllLines(myFilepPath, strset);
            }
            catch
            {
                MessageBox.Show("未能保存设置。可能因为文件不可写或者权限不足。");
            }
        }

        private Dialer dialer = new Dialer();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNkAcc.Text == "")
            {
                MessageBox.Show("请输入账号！");
                return;
            }
            if (txtNkPsw.Text == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            if (radioRouter.Checked)
            {
                dialer.BeginRouterDial(txtRtIp.Text, txtRtAcc.Text, txtRtPsw.Text, txtNkAcc.Text, txtNkPsw.Text);
            }
            if (radioLocal.Checked)
            {
                dialer.BeginLocalDial(txtLcCnn.Text, txtNkAcc.Text, txtNkPsw.Text);
            }
        }

        private void radioRouter_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = radioRouter.Checked;
            label4.Visible = radioRouter.Checked;
            label5.Visible = radioRouter.Checked;
            txtRtAcc.Visible = radioRouter.Checked;
            txtRtIp.Visible = radioRouter.Checked;
            txtRtPsw.Visible = radioRouter.Checked;
            label6.Visible = radioLocal.Checked;
            txtLcCnn.Visible = radioLocal.Checked;
            if (radioRouter.Checked)
            {
                Height = 217;
            }
            if (radioLocal.Checked)
            {
                Height = 157;
            }
        }

        private void radioLocal_CheckedChanged(object sender, EventArgs e)
        {
            radioRouter_CheckedChanged(null, null);
        }

        private void cbxAuto_CheckedChanged(object sender, EventArgs e)
        {
            string name = "NetKeeperDialer";
            string value = Application.ExecutablePath + " -s";
            RegistryKey regStartup = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            string[] names = regStartup.GetValueNames();
            if (cbxAuto.Checked)
            {
                regStartup.SetValue(name, value);
            }
            else
            {
                if (Array.IndexOf(names, name) > -1 && regStartup.GetValue(name).ToString() == value)
                {
                    regStartup.DeleteValue(name);
                }
            }
            regStartup.Close();
        }

        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string help =
                "路由器登录：" +
                "请首先确认是否支持该路由器，通常支持TP-Link，Mercury的路由器，其他品牌的也可以试试。请填写正确的IP地址、管理员用户名和密码。\r\n\r\n" +
                "本地直接登录：" + 
                "请先创建一个宽带连接，填写的连接名要和创建的宽带连接名称一致。\r\n\r\n" +
                "开机自动连接：" +
                "电脑启动后自动后台开始连接，不会显示窗口。请首先填写好各信息。如果是动态密码的用户建议不要选。\r\n\r\n" +
                "注意：" +
                "登录过程界面会出现一段时间的卡死，属正常现象，请耐心等待。登录成功后窗口会自动关闭。在有心跳服务器的地区使用本软件是无效的，即使连接成功也会在7分钟左右后断开。\r\n\r\n" +
                "iWay @ ZJUT Designed，iWay 保留所有权利。";
            MessageBox.Show(help, this.Text);
        }

        private void checker_Tick(object sender, EventArgs e)
        {
            switch (dialer.GetState())
            {
                case "Inited":
                    btnLogin.Text = "登录";
                    btnLogin.Enabled = true;
                    break;
                case "Dialing":
                    btnLogin.Text = "登录中...";
                    btnLogin.Enabled = false;
                    break;
                case "DialEnd":
                    btnLogin.Text = "登录";
                    btnLogin.Enabled = true;
                    string dialInfo = dialer.GetDialInfo();
                    if (dialInfo != "")
                    {
                        if (dialInfo.EndsWith("成功！") || dialInfo.EndsWith("无需拨号。"))
                        {
                            this.Close();
                        }
                        else
                        { 
                            dialer.Reset();
                            MessageBox.Show(dialInfo);
                            if (isAutoStart)
                            {
                                this.Close();
                            }
                        }
                    }
                    break;
            }
        }
    }
}
