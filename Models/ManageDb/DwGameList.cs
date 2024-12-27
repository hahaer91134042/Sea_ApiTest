using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 档位游戏列表
    /// </summary>
    public partial class DwGameList
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
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
