using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Channelerror
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public uint? ServerId { get; set; }
        public ushort? AgentId { get; set; }
        public string? Account { get; set; }
        public string? Type { get; set; }
        public string? Text { get; set; }
    }
}
