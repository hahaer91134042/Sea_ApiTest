using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class LoginStatus
    {
        public ulong PlayerId { get; set; }
        /// <summary>
        /// 0: 未登录；1：登录
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// 状态更新时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
