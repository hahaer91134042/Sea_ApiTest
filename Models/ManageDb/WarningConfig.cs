using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 警告通知配置
    /// </summary>
    public partial class WarningConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型 1 游戏，2，服务器，3 风控，4 日常，5 行为，6 备用一，7 备用二，8 其他
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 安全等级编号
        /// </summary>
        public sbyte? SafeUid { get; set; }
        /// <summary>
        /// 标题 用于通知开头
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 配置值1
        /// </summary>
        public int? Val1 { get; set; }
        /// <summary>
        /// 配置值2
        /// </summary>
        public int? Val2 { get; set; }
        /// <summary>
        /// 配置值3
        /// </summary>
        public int? Val3 { get; set; }
        /// <summary>
        /// 配置值4
        /// </summary>
        public string? Val4 { get; set; }
        /// <summary>
        /// 规则说明
        /// </summary>
        public string? Rule { get; set; }
        /// <summary>
        /// 通知内容格式
        /// </summary>
        public string? ContentFrom { get; set; }
        /// <summary>
        /// 邮件内容格式
        /// </summary>
        public string? EmailFrom { get; set; }
        /// <summary>
        /// 通知对象编号 U:1001;G2001
        /// </summary>
        public string? UserGpUid { get; set; }
        /// <summary>
        /// 服务器是否已读取配置 0 no,1 yes 
        /// </summary>
        public sbyte? IsRead { get; set; }
        /// <summary>
        /// 服务器读取配置时间
        /// </summary>
        public DateTime? ReadTime { get; set; }
        /// <summary>
        /// 状态 0 关闭，1 开启
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
