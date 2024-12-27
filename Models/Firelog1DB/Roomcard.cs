using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Roomcard
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public int? Count { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Operation { get; set; }
        public ulong? TargetId { get; set; }
        public string? TargetName { get; set; }
        public string? Text { get; set; }
    }
}
