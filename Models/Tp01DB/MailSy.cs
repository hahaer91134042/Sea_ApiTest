using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class MailSy
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public DateTime ExpiredTime { get; set; }
        public string Title { get; set; } = null!;
        public string? Text { get; set; }
        public ulong? Item0 { get; set; }
        public ulong? Item1 { get; set; }
        public ulong? Item2 { get; set; }
        public ulong? Item3 { get; set; }
    }
}
