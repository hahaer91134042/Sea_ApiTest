using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class UpdateVersion
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        public int Rid { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string? Info { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? Time { get; set; }
    }
}
