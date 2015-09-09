using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace NTPClient
{
    internal static class Program
    {
        /// <summary>
        /// 对时间隔
        /// </summary>
        public static int Interval = 10;

        public static string CurrentNTPServerUrl = "time.windows.com";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Process[] ps = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
                if (ps.Length > 0)
                {
                    foreach (Process p in ps)
                    {
                        if (p.Id != Process.GetCurrentProcess().Id)
                            p.Kill();
                    }
                }
                try
                {
                    string val = ConfigurationManager.AppSettings["IntervalValue"];
                    Interval = Convert.ToInt32(val);

                    CurrentNTPServerUrl = ConfigurationManager.AppSettings["CurrentNTPServerUrl"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未能正常获得时间间隔，请检查配置文件完整性。\r\n" + ex.Message);
                }

                //NTPServerList = DataAccess.GetNTPServers();

                // CurrentNTPId = NTPServerList.Where(s => s.NTPServerUrl == CurrentNTPServerUrl).Select(s => s.Id).FirstOrDefault();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}