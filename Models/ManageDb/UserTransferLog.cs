using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 红包转 账记录
    /// </summary>
    public partial class UserTransferLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 发送人ID
        /// </summary>
        public long? SendPlayerid { get; set; }
        /// <summary>
        /// 发送人昵称
        /// </summary>
        public string? SendName { get; set; }
        /// <summary>
        /// 发送红包金额
        /// </summary>
        public long? SendMoney { get; set; }
        /// <summary>
        /// 发送人余额
        /// </summary>
        public long? SendPlayerRemoney { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }
        /// <summary>
        /// 接收人ID
        /// </summary>
        public long? RecPlayerid { get; set; }
        /// <summary>
        /// 接收人昵称
        /// </summary>
        public string? RecName { get; set; }
        /// <summary>
        /// 接收红包金额
        /// </summary>
        public long? RecMoney { get; set; }
        /// <summary>
        /// 接收人余额
        /// </summary>
        public long? RecPlayerRemoney { get; set; }
        /// <summary>
        /// 打开红包密码 随机6位数据+大家字母
        /// </summary>
        public string? OpenPwd { get; set; }
        /// <summary>
        /// 是否已打开  0 未打开，1 已打开
        /// </summary>
        public sbyte? IsOpen { get; set; }
        /// <summary>
        /// 打开时间
        /// </summary>
        public DateTime? OpenTime { get; set; }
    }
}
