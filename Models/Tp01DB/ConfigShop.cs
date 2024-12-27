using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 商城配置表
    /// </summary>
    public partial class ConfigShop
    {
        public uint Id { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 筹码数量
        /// </summary>
        public uint? Money { get; set; }
        /// <summary>
        /// 赠送
        /// </summary>
        public uint? GiveMoney { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public uint? Rmb { get; set; }
        /// <summary>
        /// 购买次数限制(无限次数定义为255)
        /// </summary>
        public uint? Limit { get; set; }
        /// <summary>
        /// 每日购买次数限制(无限次数定义为255)
        /// </summary>
        public uint? DayLimit { get; set; }
        /// <summary>
        /// 限制开始时间
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// 限制结束时间
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public byte? Tag { get; set; }
        /// <summary>
        /// 商品ICON
        /// </summary>
        public byte? Icon { get; set; }
    }
}
