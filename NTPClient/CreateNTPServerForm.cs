using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NTPClient
{
    public partial class CreateNTPServerForm : Form
    {
        public CreateNTPServerForm()
        {
            InitializeComponent();
        }

        public string NTPAddress
        {
            get;
            set;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NTPAddress = txtNTPAddress.Text;
            if (IPCheck(NTPAddress))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        public bool IPCheck(string IP)
        {
            string num = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";

            return Regex.IsMatch(IP, ("^" + num + "\\." + num + "\\." + num + "\\." + num + "$"));
        }
    }
}