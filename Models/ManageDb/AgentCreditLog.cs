using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 授信操作日志
    /// </summary>
    public partial class AgentCreditLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 代理编号
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// 平台名称
        /// </summary>
        public string? Platform { get; set; }
        /// <summary>
        /// 增加金额
        /// </summary>
        public long? AddCredit { get; set; }
        /// <summary>
        /// 剩余金额
        /// </summary>
        public long? ReCredit { get; set; }
        /// <summary>
        /// 类型 1  系统，2 总代
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 总代编号
        /// </summary>
        public int? GAgentId { get; set; }
        /// <summary>
        /// 总代名称
        /// </summary>
        public string? GPlatform { get; set; }
        /// <summary>
        /// 总代剩余
        /// </summary>
        public long? GReCredit { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? AddTime { get; set; }
    }
}
