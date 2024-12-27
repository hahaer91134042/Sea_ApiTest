using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Luckdraw
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public uint? Money { get; set; }
        public byte? RewardType { get; set; }
        public string? RewardName { get; set; }
        public ushort? RewardNum { get; set; }
    }
}
