using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 免费投注-抽奖配置
    /// </summary>
    public partial class FreebetLottery
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型 1 点数，2 免费投注次数
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int? Nums { get; set; }
        /// <summary>
        /// 权值
        /// </summary>
        public int? Weight { get; set; }
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
