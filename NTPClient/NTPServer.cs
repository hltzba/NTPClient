using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTPClient
{
    /// <summary>
    /// NTP远程服务地址实体
    /// </summary>
    public class NTPServer
    {
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// NTP服务URL
        /// </summary>
        public string NTPServerUrl
        {
            get;
            set;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime
        {
            get;
            set;
        }
    }
}