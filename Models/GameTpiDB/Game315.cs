using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class Game315
    {
        public long Playerid { get; set; }
        public uint Gameid { get; set; }
        /// <summary>
        /// 下注次数
        /// </summary>
        public byte Bettick { get; set; }
        /// <summary>
        /// freespin次数
        /// </summary>
        public int Freetick { get; set; }
        /// <summary>
        /// 充值能量点
        /// </summary>
        public int Ep { get; set; }
        /// <summary>
        /// 抽奖次数
        /// </summary>
        public int? Lottery { get; set; }
        /// <summary>
        /// 红包雨-累计下注额
        /// </summary>
        public long? TotalBetMoney { get; set; }
        /// <summary>
        /// 红包雨-累计下注次数
        /// </summary>
        public int? TotalBetCount { get; set; }
        /// <summary>
        /// 红包雨-累计下注次数触发值
        /// </summary>
        public int? BetTrigger { get; set; }
    }
}
