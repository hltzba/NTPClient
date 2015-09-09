using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTPClient
{
    /// <summary>
    /// 设置对时间隔窗体
    /// </summary>
    public partial class SetIntervalForm : Form
    {
        public SetIntervalForm()
        {
            InitializeComponent();
        }

        private void SetIntervalForm_Load(object sender, EventArgs e)
        {
            try
            {
                string val = ConfigurationManager.AppSettings["IntervalValue"];
                int interval = Convert.ToInt32(val);
                numInterval.Value = interval;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未能正常获得时间间隔，请检查配置文件完整性。\r\n" + ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == "IntervalValue")
                {
                    isModified = true;
                }
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (isModified)
            {
                config.AppSettings.Settings.Remove("IntervalValue");
            }
            config.AppSettings.Settings.Add("IntervalValue", numInterval.Value.ToString());
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Program.Interval = (int)numInterval.Value;
            this.Close();
        }
    }
}