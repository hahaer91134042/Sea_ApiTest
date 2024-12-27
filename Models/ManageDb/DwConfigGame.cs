using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏档位配置
    /// </summary>
    public partial class DwConfigGame
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
        /// 产品分类编号
        /// </summary>
        public sbyte? TypeId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int GameId { get; set; }
        /// <summary>
        /// 房间编号 预留
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 档位编号
        /// </summary>
        public int DwId { get; set; }
        /// <summary>
        /// 是否读取 0 no,1 yes
        /// </summary>
        public sbyte? IsRead { get; set; }
        /// <summary>
        /// 是否自动 0 no,1 yes
        /// </summary>
        public sbyte? IsAuto { get; set; }
        /// <summary>
        /// 重置下注
        /// </summary>
        public long? ResetBet { get; set; }
        /// <summary>
        /// 重置派彩
        /// </summary>
        public long? ResetPrize { get; set; }
        /// <summary>
        /// 重置下注次数
        /// </summary>
        public int? ResetBetcounts { get; set; }
        /// <summary>
        /// 当前RTP值
        /// </summary>
        public float? RtpVal { get; set; }
        /// <summary>
        /// 当前RTP时间
        /// </summary>
        public DateTime? RtpTime { get; set; }
        /// <summary>
        /// 生效下注次数
        /// </summary>
        public int? TakeBetcount { get; set; }
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
