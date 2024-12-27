using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏运营货币表
    /// </summary>
    public partial class GameCurrency
    {
        /// <summary>
        /// 编号
        /// </summary>
        public sbyte Uid { get; set; }
        /// <summary>
        /// 符号
        /// </summary>
        public string? CurSign { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? CurName { get; set; }
        /// <summary>
        /// 货币简写
        /// </summary>
        public string? CurNameEn { get; set; }
        /// <summary>
        /// 小数位
        /// </summary>
        public sbyte? CurDecimal { get; set; }
    }
}
