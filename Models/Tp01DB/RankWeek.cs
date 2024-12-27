using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class RankWeek
    {
        public ulong PlayerId { get; set; }
        /// <summary>
        /// 排行积分，可为负数
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime Time { get; set; }
    }
}
