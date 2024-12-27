using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Money
    {
        public uint Uid { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public long? Money1 { get; set; }
        public string? Operation { get; set; }
        /// <summary>
        /// 房间ID或用户ID
        /// </summary>
        public ulong? TargetId { get; set; }
        public string? TargetName { get; set; }
        public string? Text { get; set; }
    }
}
