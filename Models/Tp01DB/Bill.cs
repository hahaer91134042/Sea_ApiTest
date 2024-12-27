using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Bill
    {
        public uint Uid { get; set; }
        /// <summary>
        /// 值充时间
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// 位单：RMB的分
        /// </summary>
        public uint Money { get; set; }
        /// <summary>
        /// 实际金额
        /// </summary>
        public int? PayMoney { get; set; }
        /// <summary>
        /// 1: 游戏道具发放完毕
        /// </summary>
        public byte Mark { get; set; }
        public uint AgentId { get; set; }
        public ulong PlayerId { get; set; }
        public uint GoodsId { get; set; }
        /// <summary>
        /// 服务器商户订单号
        /// </summary>
        public string OrderId { get; set; } = null!;
        /// <summary>
        /// 微信或第三方渠道支付订单号
        /// </summary>
        public string TransactionId { get; set; } = null!;
        /// <summary>
        /// 支付完成时间
        /// </summary>
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 订单状态 0 未完成，1 充值成功
        /// </summary>
        public byte State { get; set; }
        /// <summary>
        /// 货币单位
        /// </summary>
        public string Unit { get; set; } = null!;
        /// <summary>
        /// 砖石
        /// </summary>
        public uint Diamond { get; set; }
        /// <summary>
        /// 渠道名称
        /// </summary>
        public string Channel { get; set; } = null!;
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; } = null!;
    }
}
