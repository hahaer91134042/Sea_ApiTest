using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Guild
    {
        /// <summary>
        /// 公会编号
        /// </summary>
        public uint GuildId { get; set; }
        /// <summary>
        /// 公会名称
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// 公会等级(大厅等级)
        /// </summary>
        public byte? Level { get; set; }
        /// <summary>
        /// 告公信息
        /// </summary>
        public string? Bulletin { get; set; }
        /// <summary>
        /// 成员数量
        /// </summary>
        public ushort? MemberNum { get; set; }
        /// <summary>
        /// 成员数量上限
        /// </summary>
        public ushort? MemberMax { get; set; }
        /// <summary>
        /// 会长
        /// </summary>
        public string? Leader { get; set; }
        /// <summary>
        /// 加入等级要求
        /// </summary>
        public byte? JoinLevel { get; set; }
        /// <summary>
        /// 是否允许一键加入
        /// </summary>
        public byte? AllowAutoJoin { get; set; }
        /// <summary>
        /// 公会资金
        /// </summary>
        public uint? Bank { get; set; }
    }
}
