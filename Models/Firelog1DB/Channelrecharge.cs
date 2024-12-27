using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Channelrecharge
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ushort? ServerId { get; set; }
        public ushort? AgentId { get; set; }
        public string? Account { get; set; }
        public int? Rmb { get; set; }
        public string? OrderId { get; set; }
        public short? Status { get; set; }
        public string? Info { get; set; }
    }
}
