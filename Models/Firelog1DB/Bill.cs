using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Bill
    {
        public uint Uid { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string? Status { get; set; }
        /// <summary>
        /// 用户id
        /// </summary>
        public ulong? PlayerId { get; set; }
        /// <summary>
        /// 代理id
        /// </summary>
        public uint? AgentId { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public long? Money { get; set; }
        /// <summary>
        /// 商品id
        /// </summary>
        public ushort? GoodsId { get; set; }
        /// <summary>
        /// 订单id（内部）
        /// </summary>
        public string? OrderId { get; set; }
        /// <summary>
        /// 交易id（外部）
        /// </summary>
        public string? TransactionId { get; set; }
    }
}
