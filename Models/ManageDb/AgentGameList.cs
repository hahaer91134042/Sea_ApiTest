using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 我的游戏
    /// </summary>
    public partial class AgentGameList
    {
        /// <summary>
        /// 记录ID，唯一
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// 代理ID
        /// </summary>
        public int? AgentId { get; set; }
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 产品分类编号
        /// </summary>
        public sbyte? TypeId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 购买数量
        /// </summary>
        public int? PayAmount { get; set; }
        /// <summary>
        /// 已用数量
        /// </summary>
        public int? UseAmount { get; set; }
        /// <summary>
        /// 游戏状态 1 正常，2 关闭
        /// </summary>
        public int? GameStatus { get; set; }
        /// <summary>
        /// 提示信息 弹窗消息，空字符-无消息不弹窗
        /// </summary>
        public string? ShowInfo { get; set; }
        /// <summary>
        /// 游戏比倍开关 0 关闭，1  开启
        /// </summary>
        public sbyte? RatioMultiple { get; set; }
        /// <summary>
        /// 投注起始底分
        /// </summary>
        public float? BetInit { get; set; }
        /// <summary>
        /// 投注默认等级 默认1
        /// </summary>
        public sbyte? BetLevel { get; set; }
        /// <summary>
        /// 货币符号
        /// </summary>
        public sbyte? Currency { get; set; }
        /// <summary>
        /// 访问H5 0 no, 1 yes
        /// </summary>
        public sbyte? IsAccessH5 { get; set; }
        /// <summary>
        /// 访问webgl 0 no, 1 yes
        /// </summary>
        public sbyte? IsAccessWebgl { get; set; }
        /// <summary>
        /// 访问app 0 no, 1 yes
        /// </summary>
        public sbyte? IsAccessApp { get; set; }
        /// <summary>
        /// 免费投注功能开关 0 关，1 开
        /// </summary>
        public sbyte? IsFreespin { get; set; }
        /// <summary>
        /// 抽奖开关 0 关闭，1 开启
        /// </summary>
        public sbyte? IsLottery { get; set; }
        /// <summary>
        /// 游戏参与freespin抽奖开关，0 参与-开启，1 关闭，默认开启
        /// </summary>
        public sbyte? IsFreespinOpen { get; set; }
        /// <summary>
        /// 红包雨开关 0 关闭，1 开启
        /// </summary>
        public sbyte? RedrainOff { get; set; }
        /// <summary>
        /// 红包雨累计投注范围
        /// </summary>
        public string? RedrainBetcounts { get; set; }
    }
}
