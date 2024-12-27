using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    /// <summary>
    /// 双旦活动-积分转换
    /// </summary>
    public partial class ActivitySdExchange
    {
        /// <summary>
        /// 货币编号
        /// </summary>
        public sbyte CurId { get; set; }
        /// <summary>
        /// 转换金额，计算小数位之前
        /// </summary>
        public int? Money { get; set; }
    }
}
