using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 轮盘配置--无用 18.12.20 july
    /// </summary>
    public partial class CfRoulette
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 键值
        /// </summary>
        public string? KeyValue { get; set; }
        /// <summary>
        /// 参数值
        /// </summary>
        public string? Param { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string? KeyDesc { get; set; }
    }
}
