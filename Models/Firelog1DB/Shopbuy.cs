using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Shopbuy
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public uint? GoodsId { get; set; }
        public uint? Monery { get; set; }
        public uint? Rmb { get; set; }
    }
}
