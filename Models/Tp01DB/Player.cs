using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Player
    {
        public ulong PlayerId { get; set; }
        public string? Name { get; set; }
        public byte Sex { get; set; }
        /// <summary>
        /// 头像框
        /// </summary>
        public uint Image { get; set; }
        public int? VipPoint { get; set; }
        public byte? Level { get; set; }
        public int? Exp { get; set; }
        public long? Money { get; set; }
        public int? Rmb { get; set; }
        /// <summary>
        /// 房卡
        /// </summary>
        public int? Roomcard { get; set; }
        /// <summary>
        /// 公会编号
        /// </summary>
        public uint? GuildId { get; set; }
        public ushort? TagDate { get; set; }
        public byte? FriendNum { get; set; }
        public byte[]? Headimage { get; set; }
        public byte[]? Package { get; set; }
        public byte[]? BitTag { get; set; }
        public byte[]? SysMail { get; set; }
        /// <summary>
        /// 转出限制 0 no,1 yes
        /// </summary>
        public sbyte? LimitOut { get; set; }
    }
}
