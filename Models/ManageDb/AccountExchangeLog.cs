using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 账户转换记录
    /// </summary>
    public partial class AccountExchangeLog
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 订单编号 O+unix时间+8位大定随机字母数字
        /// </summary>
        public string? Orderid { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public int? PlayerId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 转换类型 1 转入，2 转出
        /// </summary>
        public sbyte? ExType { get; set; }
        /// <summary>
        /// 第三方金额
        /// </summary>
        public decimal? ThreeMoney { get; set; }
        /// <summary>
        /// 转换金额
        /// </summary>
        public long? ExMoney { get; set; }
        /// <summary>
        /// 转换比率
        /// </summary>
        public decimal? ExRate { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public long? ReMoney { get; set; }
        /// <summary>
        /// 授信余额
        /// </summary>
        public long? ReCredit { get; set; }
        /// <summary>
        /// 出账手续费
        /// </summary>
        public long? OutSxf { get; set; }
        /// <summary>
        /// 第三方手续费
        /// </summary>
        public decimal? ThreeSxf { get; set; }
        /// <summary>
        /// 转换状态 0 未转换，1 成功，2 失败
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 转换时间
        /// </summary>
        public DateTime? ExTime { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string? IpAddr { get; set; }
        /// <summary>
        /// 设备
        /// </summary>
        public string? Device { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Mark { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
