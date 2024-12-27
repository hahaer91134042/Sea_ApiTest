using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 代理开放游戏配置
    /// </summary>
    public partial class SyncGameOpen
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 产品分类编号
        /// </summary>
        public sbyte? TypeId { get; set; }
        /// <summary>
        /// 投注起始底分
        /// </summary>
        public decimal? BetInit { get; set; }
        /// <summary>
        /// 货币符号
        /// </summary>
        public sbyte? Currency { get; set; }
        /// <summary>
        /// 备用值1
        /// </summary>
        public string? Value1 { get; set; }
        /// <summary>
        /// 备用值2
        /// </summary>
        public string? Value2 { get; set; }
        /// <summary>
        /// 备用值3
        /// </summary>
        public string? Value3 { get; set; }
        /// <summary>
        /// 备用值4
        /// </summary>
        public string? Value4 { get; set; }
        /// <summary>
        /// 备用值5
        /// </summary>
        public string? Value5 { get; set; }
        /// <summary>
        /// 备用值6
        /// </summary>
        public string? Value6 { get; set; }
        /// <summary>
        /// 备用值7
        /// </summary>
        public string? Value7 { get; set; }
        /// <summary>
        /// 备用值8
        /// </summary>
        public string? Value8 { get; set; }
        /// <summary>
        /// 备用值9
        /// </summary>
        public string? Value9 { get; set; }
        /// <summary>
        /// 备用值10
        /// </summary>
        public string? Value10 { get; set; }
    }
}
