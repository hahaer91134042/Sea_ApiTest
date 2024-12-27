using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏数据统计-用户
    /// </summary>
    public partial class StatisGameUser
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 数据日期
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 数据类型 1 日数据，2 月数据
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 产品分类编号
        /// </summary>
        public int? TypeId { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? PlayerId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 投注
        /// </summary>
        public long? BetSum { get; set; }
        /// <summary>
        /// 派奖
        /// </summary>
        public long? AwardSum { get; set; }
        /// <summary>
        /// 盈亏
        /// </summary>
        public long? Profit { get; set; }
        /// <summary>
        /// 盈亏比例
        /// </summary>
        public decimal? ProfitRate { get; set; }
        /// <summary>
        /// 投注人数
        /// </summary>
        public int? BetUsers { get; set; }
        /// <summary>
        /// 投注次数
        /// </summary>
        public int? BetCounts { get; set; }
        /// <summary>
        /// 派奖次数
        /// </summary>
        public int? AwardCounts { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
