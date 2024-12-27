using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 注册IPMAC地址统计
    /// </summary>
    public partial class StatisRegIpmac
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// IPMAC地址
        /// </summary>
        public string IpMac { get; set; } = null!;
        /// <summary>
        /// 总数量
        /// </summary>
        public int? AllCount { get; set; }
        /// <summary>
        /// 当天数量
        /// </summary>
        public int? DayCount { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? Datetime { get; set; }
    }
}
