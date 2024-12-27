using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class FriendList
    {
        public long PlayerId { get; set; }
        /// <summary>
        /// 好友列表
        /// </summary>
        public byte[]? Friends { get; set; }
    }
}
