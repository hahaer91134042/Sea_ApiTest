using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    public partial class RoomInOut
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? PlayerId { get; set; }
        public string? PlayerName { get; set; }
        public byte? Type { get; set; }
        public ushort? BattleId { get; set; }
        public uint? RoomId { get; set; }
        public ushort? GameId { get; set; }
        public ushort? ClassId { get; set; }
        public long? Money { get; set; }
        public string? SubLabel { get; set; }
    }
}
