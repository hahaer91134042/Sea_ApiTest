using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Login
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ushort? LobbyId { get; set; }
        public string? Type { get; set; }
        public byte? Agent { get; set; }
        public string? Account { get; set; }
        public string? UserName { get; set; }
        public ulong? UserId { get; set; }
        public string? Ip { get; set; }
        public string? Uuid { get; set; }
        public string? Device { get; set; }
        public string? MacAddr { get; set; }
        public uint? PlayTime { get; set; }
        public string? SubLabel { get; set; }
    }
}
