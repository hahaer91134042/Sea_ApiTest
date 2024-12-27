using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Rmb
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public int? Rmb1 { get; set; }
        public string? Operation { get; set; }
        /// <summary>
        /// 根据Operation不同定义
        /// </summary>
        public ulong? TargetId { get; set; }
        public string? TargetName { get; set; }
        public string? Text { get; set; }
    }
}
