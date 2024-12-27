using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 幸运抽奖-奖励配置
    /// </summary>
    public partial class ConfigTurntableReward
    {
        /// <summary>
        /// 奖励编号
        /// </summary>
        public uint RewardId { get; set; }
        /// <summary>
        /// 奖励类型
        /// </summary>
        public byte? RewardType { get; set; }
        /// <summary>
        /// 子类型(只有 reward_type=3 才有子类型1-4)
        /// </summary>
        public byte? RewardSubType { get; set; }
        /// <summary>
        /// 奖励数量
        /// </summary>
        public uint? RewardNum { get; set; }
    }
}
