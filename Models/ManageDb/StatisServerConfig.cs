using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 统计服务配置
    /// </summary>
    public partial class StatisServerConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Rid { get; set; }
        /// <summary>
        /// 服务名称
        /// </summary>
        public string? ServerName { get; set; }
        /// <summary>
        /// 值描述
        /// </summary>
        public string? ServerDesc { get; set; }
        /// <summary>
        /// 值1
        /// </summary>
        public string? Value1 { get; set; }
        /// <summary>
        /// 值2
        /// </summary>
        public string? Value2 { get; set; }
        /// <summary>
        /// 值3
        /// </summary>
        public string? Value3 { get; set; }
        /// <summary>
        /// 值4
        /// </summary>
        public string? Value4 { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string? Creater { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Createtime { get; set; }
    }
}
