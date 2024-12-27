using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    public partial class RouletteRecord
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ushort? BattleId { get; set; }
        public uint? RoomId { get; set; }
        public ushort? GameId { get; set; }
        public ushort? ClassId { get; set; }
        /// <summary>
        /// 无房主时为0
        /// </summary>
        public long? OwnerId { get; set; }
        /// <summary>
        /// 0-36
        /// </summary>
        public byte? Result { get; set; }
    }
}
