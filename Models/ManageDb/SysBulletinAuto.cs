using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 跑马灯自动消息
    /// </summary>
    public partial class SysBulletinAuto
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// 随机用户名 0 no,1 yes
        /// </summary>
        public sbyte? IsName { get; set; }
        /// <summary>
        /// 随机金额 0 no,1 yes
        /// </summary>
        public sbyte? IsMoney { get; set; }
        /// <summary>
        /// 金额范围
        /// </summary>
        public string? MoneyRange { get; set; }
        /// <summary>
        /// 0全部游戏，1 随机游戏，其他-游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 单播次数 1-3次
        /// </summary>
        public sbyte? Life { get; set; }
        /// <summary>
        /// 播放次数
        /// </summary>
        public int? Counts { get; set; }
        /// <summary>
        /// 剩余次数
        /// </summary>
        public int? ReCounts { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 状态  0 关闭，1 开启，-1 删除
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
