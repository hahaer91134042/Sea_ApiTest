using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 服务日志
    /// </summary>
    public partial class StatisServerLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 服务编号
        /// </summary>
        public int? SrvId { get; set; }
        /// <summary>
        /// 服务名称
        /// </summary>
        public string? SrvName { get; set; }
        /// <summary>
        /// 消耗时间 秒
        /// </summary>
        public decimal? CostTime { get; set; }
        /// <summary>
        /// 异常错误
        /// </summary>
        public string? Error { get; set; }
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
