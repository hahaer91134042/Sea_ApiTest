using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 红包雨奖励
    /// </summary>
    public partial class RedrainReward
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型 1 点数，2 freespin
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 比例 百分比
        /// </summary>
        public decimal? Ratio { get; set; }
        /// <summary>
        /// 权重
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
