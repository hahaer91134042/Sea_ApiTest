using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    public partial class OpenPrivateRoom
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? PlayerId { get; set; }
        public string? PlayerName { get; set; }
        public ushort? BattleId { get; set; }
        public ushort? GameId { get; set; }
        public uint? RoomId { get; set; }
        public uint? Money { get; set; }
        public uint? Rmb { get; set; }
    }
}
