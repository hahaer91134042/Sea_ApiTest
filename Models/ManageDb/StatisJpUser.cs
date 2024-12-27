using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// JP统计-用户
    /// </summary>
    public partial class StatisJpUser
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
        /// JP类型  1 用户汇总，2 用户 明细
        /// </summary>
        public sbyte? JpType { get; set; }
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
        public long? PlayerId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// JP点数
        /// </summary>
        public long? JpSum { get; set; }
        /// <summary>
        /// JP次数
        /// </summary>
        public int? JpCounts { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
