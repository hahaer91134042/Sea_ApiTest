using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    public partial class Gamemoney
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public long? PlayerId { get; set; }
        public int? Io { get; set; }
        public long? Money { get; set; }
        public string? Operation { get; set; }
        public byte? SubOper { get; set; }
        public ushort? BattleId { get; set; }
        public uint? RoomId { get; set; }
        public ushort? GameId { get; set; }
        public ushort? ClassId { get; set; }
        public long? BankerId { get; set; }
        public string? Item { get; set; }
        public sbyte? IsQueriable { get; set; }
        public string? OrderId { get; set; }
        public string? ResultData { get; set; }
        public long? BetMoney { get; set; }
        public long? PrizeMoney { get; set; }
        public string? PlayerName { get; set; }
        public string RoundId { get; set; } = null!;
        public string? SubLabel { get; set; }
    }
}
