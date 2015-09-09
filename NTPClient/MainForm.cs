using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NTPClient
{
    public partial class MainForm : Form
    {
        private bool IsExitApp = false;

        private SNTPClient SNTP;
        private Thread loopThread;
        private string title = "NTP对是客户端--{0}";

        public MainForm()
        {
            InitializeComponent();

            txtCurrentNTPServer.Text = Program.CurrentNTPServerUrl;
            this.Text = string.Format(title, txtCurrentNTPServer.Text);
            SNTP = new SNTPClient(Program.CurrentNTPServerUrl);
            loopThread = new Thread(TimeSync);
            loopThread.Start();
        }

        private void TimeSync()
        {
            while (!IsExitApp)
            {
                try
                {
                    if (SNTP != null)
                    {
                        SNTP.Connect(true);
                        string content = SNTP.ToString();
                        SaveLog(content);
                    }
                    Thread.Sleep(Program.Interval * 1000);
                }
                catch (Exception ex)
                {
                    if (!IsExitApp)
                        SaveLog(ex.Message);
                    else
                        break;
                }
            }
        }

        public void SaveLog(string content)
        {
            if (this.txtTip.InvokeRequired)
            {
                txtTip.Invoke((MethodInvoker)delegate
                {
                    if (txtTip.Lines.Length > 100)
                        txtTip.Clear();
                    txtTip.AppendText(content + "\r\n");
                });
            }
            else
            {
                if (txtTip.Lines.Length > 100)
                    txtTip.Clear();
                txtTip.AppendText(content + "\r\n");
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsExitApp)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void ExitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsExitApp = true;
            if (loopThread.ThreadState == ThreadState.Running || loopThread.ThreadState == ThreadState.WaitSleepJoin)
            {
                loopThread.Abort();

                //loopThread = null;
                //loopThread.Join();
            }

            Application.Exit();
        }

        private void ModifyIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetIntervalForm form = new SetIntervalForm();
            form.ShowDialog();
        }

        private void btnTimeCheck_Click(object sender, EventArgs e)
        {
            if (btnTimeCheck.Tag.ToString() == "Modify")
            {
                txtCurrentNTPServer.ReadOnly = false;
                btnTimeCheck.Text = "确定";
                btnTimeCheck.Tag = "OK";
            }
            else if (btnTimeCheck.Tag.ToString() == "OK")
            {
                if (string.IsNullOrEmpty(txtCurrentNTPServer.Text))
                {
                    MessageBox.Show("NTP服务器的地址不能为空");
                    return;
                }

                Program.CurrentNTPServerUrl = txtCurrentNTPServer.Text;
                txtCurrentNTPServer.ReadOnly = true;
                btnTimeCheck.Tag = "Modify";
                btnTimeCheck.Text = "修改";

                bool isModified = false;
                foreach (string key in ConfigurationManager.AppSettings)
                {
                    if (key == "CurrentNTPServerUrl")
                    {
                        isModified = true;
                    }
                }
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (isModified)
                {
                    config.AppSettings.Settings.Remove("CurrentNTPServerUrl");
                }
                config.AppSettings.Settings.Add("CurrentNTPServerUrl", txtCurrentNTPServer.Text);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");

                SNTP = new SNTPClient(Program.CurrentNTPServerUrl);
                this.Text = string.Format(title, txtCurrentNTPServer.Text);
            }
        }
    }
}