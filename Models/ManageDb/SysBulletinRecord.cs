using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 系统跑马灯记录(系统游戏消息)
    /// </summary>
    public partial class SysBulletinRecord
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 显示类型 0 全部游戏，game_id 单独游戏，多游戏则写多条记录
        /// </summary>
        public int? Showtype { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// 循环次数
        /// </summary>
        public sbyte? Life { get; set; }
        /// <summary>
        /// 状态 1 成功，2 失败
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 发送人
        /// </summary>
        public string? Sender { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? SendTime { get; set; }
    }
}
