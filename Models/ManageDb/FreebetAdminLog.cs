using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 免费下注次数发放记录
    /// </summary>
    public partial class FreebetAdminLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 操作类型 1 人工，2 抽奖，5 红包雨
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 赠送类型 1 免费投注，2 抽奖
        /// </summary>
        public sbyte? SendType { get; set; }
        /// <summary>
        /// 游戏编号  0 全部，其他 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 玩家编号 0 全部，其他 玩家编号
        /// </summary>
        public long? PlayerId { get; set; }
        /// <summary>
        /// 玩家账号 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 发送数量
        /// </summary>
        public int? SendCounts { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
