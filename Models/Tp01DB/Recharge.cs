using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Recharge
    {
        public ulong PlayerId { get; set; }
        public byte Status { get; set; }
        public DateTime? Time { get; set; }
    }
}
