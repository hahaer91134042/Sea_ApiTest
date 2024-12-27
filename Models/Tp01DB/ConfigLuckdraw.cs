using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 幸运抽奖-抽奖次数奖励配置
    /// </summary>
    public partial class ConfigLuckdraw
    {
        /// <summary>
        /// 编号
        /// </summary>
        public byte Id { get; set; }
        /// <summary>
        /// 充值额
        /// </summary>
        public ulong? Recharge { get; set; }
        /// <summary>
        /// 总押注额
        /// </summary>
        public ulong? TotalBet { get; set; }
        /// <summary>
        /// 赠送次数
        /// </summary>
        public byte? GiveNum { get; set; }
    }
}
