using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class FriendAuthen
    {
        public uint PlayerId { get; set; }
        /// <summary>
        /// 需认证的角色ID
        /// </summary>
        public uint AuthenId { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime ExpiredTime { get; set; }
    }
}
