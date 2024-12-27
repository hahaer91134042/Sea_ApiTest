using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏RTP记录
    /// </summary>
    public partial class DwRtpLog
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
        /// 累计下注
        /// </summary>
        public long? TotalBet { get; set; }
        /// <summary>
        /// 累计派彩
        /// </summary>
        public long? TotalPrize { get; set; }
        /// <summary>
        /// 下注次数
        /// </summary>
        public int? CountBet { get; set; }
        /// <summary>
        /// 派彩次数
        /// </summary>
        public int? CountPrize { get; set; }
        /// <summary>
        /// RTP
        /// </summary>
        public float? Rtp { get; set; }
        /// <summary>
        /// 档位编号_旧
        /// </summary>
        public sbyte? DwIdOld { get; set; }
        /// <summary>
        /// 档位编号_新
        /// </summary>
        public sbyte? DwIdNew { get; set; }
        /// <summary>
        /// 是否已重置 0 NO,1 YES
        /// </summary>
        public sbyte? IsReset { get; set; }
        /// <summary>
        /// 是否已生产 0 NO,1 YES
        /// </summary>
        public sbyte? IsTake { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime? InsertTime { get; set; }
    }
}
