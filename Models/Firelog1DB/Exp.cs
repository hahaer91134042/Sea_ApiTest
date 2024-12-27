using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Exp
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public long? Exp1 { get; set; }
        public string? Type { get; set; }
    }
}
