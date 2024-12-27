using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 档位修改记录
    /// </summary>
    public partial class DwChangeLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 代理编号
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 房间编号
        /// </summary>
        public int? RoomId { get; set; }
        /// <summary>
        /// 档位编号
        /// </summary>
        public int? DwId { get; set; }
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
