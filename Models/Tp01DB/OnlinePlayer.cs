using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 用户实时在线表，只针对进入游戏房间的玩家，非登录大厅状态，金币为带入房间的金币数
    /// </summary>
    public partial class OnlinePlayer
    {
        public ulong PlayerId { get; set; }
        /// <summary>
        /// 玩家名称
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// 游戏编号
        /// </summary>
        public uint GameId { get; set; }
        /// <summary>
        /// 游戏类别
        /// </summary>
        public uint ClassId { get; set; }
        /// <summary>
        /// 设备类型：pc,android,ios
        /// </summary>
        public string Device { get; set; } = null!;
        /// <summary>
        /// 插入时间戳
        /// </summary>
        public DateTime Time { get; set; }
    }
}
