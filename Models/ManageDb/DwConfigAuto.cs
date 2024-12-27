using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 自动档位配置
    /// </summary>
    public partial class DwConfigAuto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 代理编号
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int GameId { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public string? Stime { get; set; }
        /// <summary>
        /// 开始时间 整型
        /// </summary>
        public int? StimeInt { get; set; }
        /// <summary>
        /// 档位编号
        /// </summary>
        public int DwId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
