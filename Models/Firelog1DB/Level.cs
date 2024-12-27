using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Level
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? UserId { get; set; }
        public string? UserName { get; set; }
        public int? Level1 { get; set; }
        public int? SourceLevel { get; set; }
        public string? Text { get; set; }
    }
}
