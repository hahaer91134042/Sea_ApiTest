using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 红包雨配置
    /// </summary>
    public partial class RedrainConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 累计投注范围
        /// </summary>
        public string? TotalBetcounts { get; set; }
        /// <summary>
        /// freespin换算点数
        /// </summary>
        public int? FreespinPrice { get; set; }
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
