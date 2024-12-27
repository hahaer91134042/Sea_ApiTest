using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class IpChina
    {
        /// <summary>
        /// 开始IP整型
        /// </summary>
        public long Sint { get; set; }
        /// <summary>
        /// 结束IP整型
        /// </summary>
        public long Eint { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string? Province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string? City { get; set; }
    }
}
