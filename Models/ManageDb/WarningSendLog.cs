using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 警告通知发送日志
    /// </summary>
    public partial class WarningSendLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 警告通知编号
        /// </summary>
        public int? WarningUid { get; set; }
        /// <summary>
        /// 通知标题
        /// </summary>
        public string? WarningTitle { get; set; }
        /// <summary>
        /// 安全等级名称
        /// </summary>
        public string? SafeName { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? PlayerId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string? Account { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 值1
        /// </summary>
        public int? Val1 { get; set; }
        /// <summary>
        /// 值2
        /// </summary>
        public int? Val2 { get; set; }
        /// <summary>
        /// 值3
        /// </summary>
        public int? Val3 { get; set; }
        /// <summary>
        /// 值4
        /// </summary>
        public string? Val4 { get; set; }
        /// <summary>
        /// 当前值1
        /// </summary>
        public string? NowVal1 { get; set; }
        /// <summary>
        /// 手机通知状态 0 no ,1 yes
        /// </summary>
        public sbyte? PhoneState { get; set; }
        /// <summary>
        /// 邮箱通知状态 0 no,1 yes
        /// </summary>
        public sbyte? EmailState { get; set; }
        /// <summary>
        /// 是否已读 0 no 1 yes 
        /// </summary>
        public sbyte? IsRead { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }
    }
}
