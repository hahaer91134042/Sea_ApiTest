using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 警告通知人员分组
    /// </summary>
    public partial class WarningUserGroup
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 分组名称
        /// </summary>
        public string? GroupName { get; set; }
    }
}
