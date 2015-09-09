namespace NTPClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimeCheck = new System.Windows.Forms.Button();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifyIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurrentNTPServer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间服务器地址：";
            // 
            // btnTimeCheck
            // 
            this.btnTimeCheck.Location = new System.Drawing.Point(365, 17);
            this.btnTimeCheck.Name = "btnTimeCheck";
            this.btnTimeCheck.Size = new System.Drawing.Size(173, 22);
            this.btnTimeCheck.TabIndex = 2;
            this.btnTimeCheck.Tag = "Modify";
            this.btnTimeCheck.Text = "修改";
            this.btnTimeCheck.UseVisualStyleBackColor = true;
            this.btnTimeCheck.Click += new System.EventHandler(this.btnTimeCheck_Click);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(5, 64);
            this.txtTip.MaxLength = 327670000;
            this.txtTip.Multiline = true;
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTip.Size = new System.Drawing.Size(544, 248);
            this.txtTip.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NTP对时";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyIntervalToolStripMenuItem,
            this.ExitApplicationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // ModifyIntervalToolStripMenuItem
            // 
            this.ModifyIntervalToolStripMenuItem.Name = "ModifyIntervalToolStripMenuItem";
            this.ModifyIntervalToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ModifyIntervalToolStripMenuItem.Text = "修改对时间隔";
            this.ModifyIntervalToolStripMenuItem.Click += new System.EventHandler(this.ModifyIntervalToolStripMenuItem_Click);
            // 
            // ExitApplicationToolStripMenuItem
            // 
            this.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem";
            this.ExitApplicationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ExitApplicationToolStripMenuItem.Text = "退出";
            this.ExitApplicationToolStripMenuItem.Click += new System.EventHandler(this.ExitApplicationToolStripMenuItem_Click);
            // 
            // txtCurrentNTPServer
            // 
            this.txtCurrentNTPServer.Location = new System.Drawing.Point(110, 17);
            this.txtCurrentNTPServer.Name = "txtCurrentNTPServer";
            this.txtCurrentNTPServer.ReadOnly = true;
            this.txtCurrentNTPServer.Size = new System.Drawing.Size(236, 21);
            this.txtCurrentNTPServer.TabIndex = 4;
            this.txtCurrentNTPServer.Text = "time.windows.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 324);
            this.Controls.Add(this.txtCurrentNTPServer);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.btnTimeCheck);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NTP对时客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimeCheck;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ModifyIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitApplicationToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCurrentNTPServer;
    }
}

