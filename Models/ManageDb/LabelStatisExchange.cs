using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 账户转换统计
    /// </summary>
    public partial class LabelStatisExchange
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 数据类型 1 日数据，2 月数据
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 转入人数
        /// </summary>
        public int? ExinUsers { get; set; }
        /// <summary>
        /// 转入次数
        /// </summary>
        public int? ExinCounts { get; set; }
        /// <summary>
        /// 转入第三方金额
        /// </summary>
        public decimal? ExinThrMoney { get; set; }
        /// <summary>
        /// 转入金额
        /// </summary>
        public long? ExinMoney { get; set; }
        /// <summary>
        /// 转入比率
        /// </summary>
        public decimal? ExinRate { get; set; }
        /// <summary>
        /// 转出人数
        /// </summary>
        public int? ExoutUsers { get; set; }
        /// <summary>
        /// 转出次数
        /// </summary>
        public int? ExoutCounts { get; set; }
        /// <summary>
        /// 转出第三方金额
        /// </summary>
        public decimal? ExoutThrMoney { get; set; }
        /// <summary>
        /// 转出金额
        /// </summary>
        public long? ExoutMoney { get; set; }
        /// <summary>
        /// 转出比率
        /// </summary>
        public decimal? ExoutRate { get; set; }
        /// <summary>
        /// 转出人数占比  转出人数/(转入人数+转出人数)百分比 保留两位小数，不四舍
        /// </summary>
        public decimal? ExoutUserRate { get; set; }
        /// <summary>
        /// 转出金额占比  转出金额/(转入金额+转出金额)百分比 保留两位小数，不四舍
        /// </summary>
        public decimal? ExoutMoneyRate { get; set; }
        /// <summary>
        /// 盈亏   转出金额 - 转入金额
        /// </summary>
        public long? Profit { get; set; }
        /// <summary>
        /// 盈亏比率   盈亏/转入金额 百分比 保留两位小数。不四舍
        /// </summary>
        public decimal? ProftRate { get; set; }
        /// <summary>
        /// 第三方盈亏
        /// </summary>
        public decimal? ThrProfit { get; set; }
        /// <summary>
        /// 第三方盈亏率。
        /// </summary>
        public decimal? ThrProfitRate { get; set; }
        /// <summary>
        /// 出账手续费
        /// </summary>
        public long? OutSxf { get; set; }
        /// <summary>
        /// 第三方手续费
        /// </summary>
        public decimal? ThreeSxf { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
