using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 时实盈亏-后台总览使用
    /// </summary>
    public partial class StatisProfitNow
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public long? PlayerId { get; set; }
        /// <summary>
        /// 下注次数
        /// </summary>
        public int? BetCounts { get; set; }
        /// <summary>
        /// 下注金额
        /// </summary>
        public long? BetSum { get; set; }
        /// <summary>
        /// 派彩次数
        /// </summary>
        public int? AwardCounts { get; set; }
        /// <summary>
        /// 派彩金额
        /// </summary>
        public long? AwardSum { get; set; }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime? InsertTime { get; set; }
        /// <summary>
        /// 子标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
