using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏在线人数统计表 分：保存2小时数据，时：24小时，日：31日，月：12月
    /// </summary>
    public partial class StatisGameOnline
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// 数据类别 1 汇总，2 按游戏，3 按设备
        /// </summary>
        public sbyte? DataType { get; set; }
        /// <summary>
        /// 时间分类 1 分，2 时，3 日，4 月
        /// </summary>
        public sbyte? TimeType { get; set; }
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 设备类型 
        /// </summary>
        public string? Device { get; set; }
        /// <summary>
        /// 在线人数 单位时间最高同时在线
        /// </summary>
        public int? OnlineAmount { get; set; }
        /// <summary>
        /// 统计时间
        /// </summary>
        public DateTime? StatisTime { get; set; }
    }
}
