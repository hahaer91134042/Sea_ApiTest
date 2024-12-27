using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 代理信息表
    /// </summary>
    public partial class SyncAgentInfo
    {
        /// <summary>
        /// 代理ID
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// Game服务器地址
        /// </summary>
        public string? GameSrvIp { get; set; }
        /// <summary>
        /// Game服务器端口
        /// </summary>
        public string? GameSrvPort { get; set; }
        /// <summary>
        /// Web服务器地址
        /// </summary>
        public string? WebSrvIp { get; set; }
        /// <summary>
        /// 货币转换率
        /// </summary>
        public decimal? ChipRate { get; set; }
        /// <summary>
        /// 授信额度
        /// </summary>
        public long? CreditLine { get; set; }
        /// <summary>
        /// 当前额度
        /// </summary>
        public long? NowCredit { get; set; }
        /// <summary>
        /// 出账手续费
        /// </summary>
        public decimal? CcRate { get; set; }
        /// <summary>
        /// 出账手续费定额
        /// </summary>
        public decimal? CcFixed { get; set; }
        /// <summary>
        /// 代理状态 0 正常，1 关闭，-1 删除
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 信任码
        /// </summary>
        public string? TrustCode { get; set; }
        /// <summary>
        /// 系统码
        /// </summary>
        public string? SystemCode { get; set; }
        /// <summary>
        /// 后台小数位 0无小数
        /// </summary>
        public sbyte? HdDecimal { get; set; }
        /// <summary>
        /// 代理域名，调用接口用
        /// </summary>
        public string? DomainName { get; set; }
        /// <summary>
        /// 平台名称
        /// </summary>
        public string? Platform { get; set; }
        /// <summary>
        /// 上级代理编号
        /// </summary>
        public int? FatherId { get; set; }
        /// <summary>
        /// 大JP状态 0 正常（默认），1 限制出大JP
        /// </summary>
        public sbyte? BigjpState { get; set; }
        /// <summary>
        /// 货币编号
        /// </summary>
        public int? CurId { get; set; }
        /// <summary>
        /// Jackpot开关，0 关闭，1 开启
        /// </summary>
        public sbyte? JpClose { get; set; }
        /// <summary>
        /// freespin显示开关 0 NO，1 YES 
        /// </summary>
        public sbyte? IsFreespin { get; set; }
        /// <summary>
        /// 转盘抽奖开关 0 关闭，1 开启
        /// </summary>
        public sbyte? LuckdrawOff { get; set; }
        /// <summary>
        /// 红包雨开关 0 关闭，1 开启
        /// </summary>
        public sbyte? RedenvelopeOff { get; set; }
        /// <summary>
        /// 后台&amp;客户端LOGO切换 值1：1 SEA，2 欧洲gamedivision
        /// </summary>
        public sbyte? ChangeLogo { get; set; }
    }
}
