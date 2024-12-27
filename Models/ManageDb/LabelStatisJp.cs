using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// JP统计
    /// </summary>
    public partial class LabelStatisJp
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
        /// JP点数
        /// </summary>
        public long? JpSum { get; set; }
        /// <summary>
        /// JP用户数
        /// </summary>
        public int? JpUsers { get; set; }
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
