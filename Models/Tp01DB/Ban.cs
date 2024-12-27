using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Ban
    {
        public ulong PlayerId { get; set; }
        public DateTime MarkTime { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ChatTime { get; set; }
        public string LoginInfo { get; set; } = null!;
        public string ChatInfo { get; set; } = null!;
    }
}
