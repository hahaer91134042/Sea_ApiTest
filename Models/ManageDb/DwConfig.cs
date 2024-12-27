using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 档位配置
    /// </summary>
    public partial class DwConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int DwId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string DwName { get; set; } = null!;
        /// <summary>
        /// 分类编号
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int GameId { get; set; }
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
