using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Onlineuser
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public string? Name { get; set; }
        /// <summary>
        /// 游戏标识
        /// </summary>
        public ushort? GameId { get; set; }
        /// <summary>
        /// 游戏子类型
        /// </summary>
        public ushort? ClassId { get; set; }
        public int? Count { get; set; }
    }
}
