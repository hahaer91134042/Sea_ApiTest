using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 自动切换档位触发配置
    /// </summary>
    public partial class DwConfigTrigger
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 触发档位
        /// </summary>
        public sbyte? DwId { get; set; }
        /// <summary>
        /// 触发阀值
        /// </summary>
        public int? TriggerVal { get; set; }
    }
}
