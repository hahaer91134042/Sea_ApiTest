using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Updatedatum
    {
        public uint Uid { get; set; }
        public DateTime Time { get; set; }
        public ulong? PlayerId { get; set; }
        /// <summary>
        /// 游戏id
        /// </summary>
        public ushort? GameId { get; set; }
        /// <summary>
        /// 分类id
        /// </summary>
        public ushort? ClassId { get; set; }
        /// <summary>
        /// 记录id，用于快速检查
        /// </summary>
        public uint? RecordId { get; set; }
        public long? Money { get; set; }
        public uint? Roomcard { get; set; }
    }
}
