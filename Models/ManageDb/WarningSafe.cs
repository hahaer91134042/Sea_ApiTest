using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 警告通知安全等级
    /// </summary>
    public partial class WarningSafe
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? SafeName { get; set; }
    }
}
