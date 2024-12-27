using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 接口管理
    /// </summary>
    public partial class SyncApiManage
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 接口类型 1 web,2 game
        /// </summary>
        public sbyte? ApiType { get; set; }
        /// <summary>
        /// 接口名称
        /// </summary>
        public string? ApiName { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string? ApiInfo { get; set; }
        /// <summary>
        /// 调用源
        /// </summary>
        public string? CallSource { get; set; }
        /// <summary>
        /// 接口文档
        /// </summary>
        public string? DocumentUrl { get; set; }
        /// <summary>
        /// IP限制 0 no ,1 yes
        /// </summary>
        public sbyte? IpLimit { get; set; }
    }
}
