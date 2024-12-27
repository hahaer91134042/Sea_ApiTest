using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 活动数据推送开关
    /// </summary>
    public partial class SyncActivityPush
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 数据描述 用户投注数据
        /// </summary>
        public string? DataDesc { get; set; }
        /// <summary>
        /// 推送开关  0 no,1 yes
        /// </summary>
        public sbyte? IsPush { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
    }
}
