using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 用户账户操作记录
    /// </summary>
    public partial class AccountAdminLog
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 操作类型 1 人工，2 抽奖，5 红包雨
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? PlayerId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public long? ChangeMoney { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public long? ReMoney { get; set; }
        /// <summary>
        /// 修改原因
        /// </summary>
        public string? Reson { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
