using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Suggestion
    {
        public uint Uid { get; set; }
        public ulong Userid { get; set; }
        public byte Mark { get; set; }
        public DateTime Time { get; set; }
        public string Phone { get; set; } = null!;
        public string Text { get; set; } = null!;
    }
}
