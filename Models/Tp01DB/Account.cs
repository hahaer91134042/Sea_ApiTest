using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Account
    {
        /// <summary>
        /// 分组编号，最大不超过63
        /// </summary>
        public byte ZoneId { get; set; }
        /// <summary>
        /// 0为数据库验证，渠道ID必须大于0
        /// </summary>
        public byte Agent { get; set; }
        public ulong PlayerId { get; set; }
        public string Name { get; set; } = null!;
        public string Passwd { get; set; } = null!;
        public byte GmLevel { get; set; }
        public byte Adult { get; set; }
        /// <summary>
        /// 推广员
        /// </summary>
        public ulong Spreader { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        /// <summary>
        /// 设备名称
        /// </summary>
        public string Device { get; set; } = null!;
        /// <summary>
        /// UUID
        /// </summary>
        public string Uuid { get; set; } = null!;
        /// <summary>
        /// 卡网地址
        /// </summary>
        public string MacAddr { get; set; } = null!;
        /// <summary>
        /// 注册ip
        /// </summary>
        public string IpAddr { get; set; } = null!;
        /// <summary>
        /// 录登IP地址
        /// </summary>
        public string LoginIp { get; set; } = null!;
        public DateTime CreateTime { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
        /// <summary>
        /// 总在线时间,单位分钟
        /// </summary>
        public uint PlayTime { get; set; }
        /// <summary>
        /// 充值bill表状态标识
        /// </summary>
        public sbyte BillMark { get; set; }
        /// <summary>
        /// 是否游客 0 no,1 yes
        /// </summary>
        public sbyte? Isguest { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
