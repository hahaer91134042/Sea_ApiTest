using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Shop
    {
        /// <summary>
        /// 唯一索引
        /// </summary>
        public uint GoodsId { get; set; }
        /// <summary>
        /// 实际金额，单位：分
        /// </summary>
        public uint Money { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc { get; set; } = null!;
        /// <summary>
        /// 商品图标
        /// </summary>
        public string Image { get; set; } = null!;
        /// <summary>
        /// 兑换类型，支持：roomcard,rmb,item
        /// </summary>
        public string ExchangeType { get; set; } = null!;
        /// <summary>
        /// 兑换数值
        /// </summary>
        public uint ExchangeValue0 { get; set; }
        /// <summary>
        /// 兑换数值
        /// </summary>
        public uint ExchangeValue1 { get; set; }
    }
}
