using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class GameTp01
    {
        public long Playerid { get; set; }
        /// <summary>
        /// 回合数
        /// </summary>
        public uint? Round { get; set; }
        /// <summary>
        /// 游戏时间，单位：秒
        /// </summary>
        public uint? Gametime { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int? Score { get; set; }
        public int? Bw { get; set; }
        public int? VirtualScore { get; set; }
        public int? Win { get; set; }
        public int? Lose { get; set; }
    }
}
