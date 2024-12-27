using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 用户数据统计
    /// </summary>
    public partial class StatisUser
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int PlayerId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 最大投注
        /// </summary>
        public int? BetMax { get; set; }
        /// <summary>
        /// 最大派奖
        /// </summary>
        public int? AwardMax { get; set; }
        /// <summary>
        /// 累计投注
        /// </summary>
        public long? BetSum { get; set; }
        /// <summary>
        /// 累计派奖
        /// </summary>
        public long? AwardSum { get; set; }
        /// <summary>
        /// 累计投注次数
        /// </summary>
        public int? BetsSum { get; set; }
        /// <summary>
        /// 累计派奖次数
        /// </summary>
        public int? AwardsSum { get; set; }
        /// <summary>
        /// 胜率
        /// </summary>
        public decimal? WinRate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
