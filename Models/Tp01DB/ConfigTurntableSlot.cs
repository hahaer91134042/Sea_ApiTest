using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 幸运抽奖-概率配置
    /// </summary>
    public partial class ConfigTurntableSlot
    {
        /// <summary>
        /// 轮次
        /// </summary>
        public byte Turntable { get; set; }
        /// <summary>
        /// 转盘位置
        /// </summary>
        public byte Slot { get; set; }
        /// <summary>
        /// 权值，百分比
        /// </summary>
        public ushort? Weight { get; set; }
        public uint? RewardId { get; set; }
    }
}
