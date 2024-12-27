using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 活跃统计
    /// </summary>
    public partial class StatisActive
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
        /// 数据类型 1，汇总，2 按设备
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public string? Device { get; set; }
        /// <summary>
        /// 新增人数
        /// </summary>
        public int? AddUsers { get; set; }
        /// <summary>
        /// 活跃人数
        /// </summary>
        public int? ActiveUsers { get; set; }
        /// <summary>
        /// 投注人数
        /// </summary>
        public int? BetUsers { get; set; }
        /// <summary>
        /// 次日留存
        /// </summary>
        public int? YesdKeep { get; set; }
        /// <summary>
        /// 三日留存
        /// </summary>
        public int? ThreeKeep { get; set; }
        /// <summary>
        /// 五日留存
        /// </summary>
        public int? FiveKeep { get; set; }
        /// <summary>
        /// 七日留存
        /// </summary>
        public int? SevenKeep { get; set; }
        /// <summary>
        /// 保留15天
        /// </summary>
        public int? FifteenKeep { get; set; }
        /// <summary>
        /// 保留30天
        /// </summary>
        public int? ThirtyKeep { get; set; }
    }
}
