using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Friend
    {
        public uint PlayerId { get; set; }
        /// <summary>
        /// 好友player_id
        /// </summary>
        public uint FriendId { get; set; }
        /// <summary>
        /// 体力值赠送时间
        /// </summary>
        public DateTime? VigourDonateTime { get; set; }
        /// <summary>
        /// 体力值收接时间
        /// </summary>
        public DateTime? VigourRecvTime { get; set; }
    }
}
