using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTPClient
{
    /// <summary>
    /// 运行日志
    /// </summary>
    public class ProcessLog
    {
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// NTP服务ID，对应NTPServer主键
        /// </summary>
        public int ServerId
        {
            get;
            set;
        }

        /// <summary>
        /// 同步获取内容
        /// </summary>
        public string ServerReceiveContent
        {
            get;
            set;
        }

        /// <summary>
        /// 开始对时时间
        /// </summary>
        public DateTime CreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 返回时间
        /// </summary>
        public DateTime ReceiveTime
        {
            get;
            set;
        }
    }
}