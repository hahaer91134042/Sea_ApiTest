using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class RaidersLevel
    {
        public long Playerid { get; set; }
        public int Level { get; set; }
        /// <summary>
        /// 开宝箱数量
        /// </summary>
        public int OpenCount { get; set; }
        /// <summary>
        /// 龙珠数量
        /// </summary>
        public int DragonCount { get; set; }
        public int Bet { get; set; }
        public int WinCoin { get; set; }
    }
}
