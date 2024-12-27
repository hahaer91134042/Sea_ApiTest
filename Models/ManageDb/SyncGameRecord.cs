using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏记录推送同步
    /// </summary>
    public partial class SyncGameRecord
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 本次记录ID
        /// </summary>
        public long? GameUid { get; set; }
        /// <summary>
        /// 上次记录ID
        /// </summary>
        public long? LastGameUid { get; set; }
        /// <summary>
        /// 当前成功推送uid
        /// </summary>
        public long? SuccessUid { get; set; }
        /// <summary>
        /// 记录数量
        /// </summary>
        public int? Counts { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// 推送次数
        /// </summary>
        public int? PushCounts { get; set; }
        /// <summary>
        /// 推送状态 0 开始推送，1 成功，2 失败
        /// </summary>
        public sbyte? State { get; set; }
    }
}
