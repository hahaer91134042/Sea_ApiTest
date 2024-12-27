using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 跑马灯自动消息日志
    /// </summary>
    public partial class SysBulletinAutoLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 自动消息编号
        /// </summary>
        public int? AutoUid { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// 发送状态 0 失败，1 成功
        /// </summary>
        public sbyte? SendState { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }
    }
}
