using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 免费下注抽奖统计-标签分组
    /// </summary>
    public partial class LabelStatisFreebetLottery
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// 数据类型 1 日数据，2 月数据
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 派彩金额
        /// </summary>
        public long? AwardSum { get; set; }
        /// <summary>
        /// 抽奖金额
        /// </summary>
        public long? LotterySum { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
