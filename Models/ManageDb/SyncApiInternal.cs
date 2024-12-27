using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 内部接口
    /// </summary>
    public partial class SyncApiInternal
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 来源 1 代理，2 游戏
        /// </summary>
        public sbyte? ApiSource { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? ApiName { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string? ApiInfo { get; set; }
        /// <summary>
        /// 调用名
        /// </summary>
        public string? ApiPath { get; set; }
        /// <summary>
        /// 信任码
        /// </summary>
        public string? TrustCode { get; set; }
        /// <summary>
        /// 接口文档
        /// </summary>
        public string? DocumentUrl { get; set; }
    }
}
