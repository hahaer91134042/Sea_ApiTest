using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Channellogin
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public uint? ServerId { get; set; }
        public ushort? AgentId { get; set; }
        public string? Account { get; set; }
        public uint? Code { get; set; }
        public string? Info { get; set; }
    }
}
