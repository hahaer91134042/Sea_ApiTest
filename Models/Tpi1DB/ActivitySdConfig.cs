using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    /// <summary>
    /// 双旦活动配置-圣诞、元旦
    /// </summary>
    public partial class ActivitySdConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public string? GameId { get; set; }
    }
}
