using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 遊戲水池紀錄
    /// </summary>
    public partial class DwRtpPreprimed
    {

        /// <summary>
        /// 需客製化RTP的遊戲ID
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        /// 客製化初始下注額
        /// </summary>
        public long BetInit { get; set; }

        /// <summary>
        /// 客製化初始獎金額
        /// </summary>
        public long PrizeInit { get; set; }
    }
}
