using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 轮盘房间配置表
    /// </summary>
    public partial class RoomConfigRoulette
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int GameId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 代理编号
        /// </summary>
        public int AgentId { get; set; }
        /// <summary>
        /// 房间名称
        /// </summary>
        public string? RoomName { get; set; }
        /// <summary>
        /// 房间标签 比如低中高
        /// </summary>
        public string? RoomTag { get; set; }
        /// <summary>
        /// 最大人数
        /// </summary>
        public int? UsersMax { get; set; }
        /// <summary>
        /// 当前人数
        /// </summary>
        public int? UsersNow { get; set; }
        /// <summary>
        /// 最大局数 0  无限制
        /// </summary>
        public int? InningsMax { get; set; }
        /// <summary>
        /// 当前局数
        /// </summary>
        public int? InningsNow { get; set; }
        /// <summary>
        /// 庄家筹码上限
        /// </summary>
        public long? BankerUpperLimit { get; set; }
        /// <summary>
        /// 庄家筹码下限
        /// </summary>
        public long? BankerLowerLimit { get; set; }
        /// <summary>
        /// 下庄安全阀值 百分比
        /// </summary>
        public sbyte? DownSafeValue { get; set; }
        /// <summary>
        /// 庄家续筹码 0 no,1  yes
        /// </summary>
        public sbyte? BankerReplenish { get; set; }
        /// <summary>
        /// 设定庄家筹码值
        /// </summary>
        public long? BankerCoin { get; set; }
        /// <summary>
        /// 押注筹码1档
        /// </summary>
        public int? BetChip1 { get; set; }
        /// <summary>
        /// 押注筹码2档
        /// </summary>
        public int? BetChip2 { get; set; }
        /// <summary>
        /// 押注筹码3档
        /// </summary>
        public int? BetChip3 { get; set; }
        /// <summary>
        /// 押注筹码4档
        /// </summary>
        public int? BetChip4 { get; set; }
        /// <summary>
        /// 押注筹码5档
        /// </summary>
        public int? BetChip5 { get; set; }
        /// <summary>
        /// 允许玩家上庄 0 否，1 是
        /// </summary>
        public sbyte? IsUserBanker { get; set; }
        /// <summary>
        /// 玩家上庄筹码
        /// </summary>
        public long? UserBankerChips { get; set; }
        /// <summary>
        /// 玩家上庄局数
        /// </summary>
        public long? UserBankerInnings { get; set; }
        /// <summary>
        /// 当前庄家 1 系统，2 玩家
        /// </summary>
        public sbyte? BankerNow { get; set; }
        /// <summary>
        /// 当前庄家筹码
        /// </summary>
        public long? BankerChipsNow { get; set; }
        /// <summary>
        /// 单号码累计押注触发
        /// </summary>
        public long? SingleNumberBet { get; set; }
        /// <summary>
        /// 组合号码累计押注触发
        /// </summary>
        public long? AssmbleBet { get; set; }
        /// <summary>
        /// 单号码累计押注限制
        /// </summary>
        public long? SingleNumberLimit { get; set; }
        /// <summary>
        /// 组合号码累计押注限制
        /// </summary>
        public long? AssmbleLimit { get; set; }
        /// <summary>
        /// 排序类型   1-10  升序 【(预留) 1 置顶，2 在线人数，3 自动】
        /// </summary>
        public sbyte? OrderType { get; set; }
        /// <summary>
        /// VIP限制 (预留) 0 不限制，1 只有VIP可以进入
        /// </summary>
        public sbyte? VipLimit { get; set; }
        /// <summary>
        /// 购买时间
        /// </summary>
        public DateTime? BuyTime { get; set; }
        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime? ExpireTime { get; set; }
        /// <summary>
        /// 房间状态 0 正常，1 关闭,-1删除
        /// </summary>
        public sbyte? RoomState { get; set; }
        /// <summary>
        /// 配置状态 0 未配置，1 已配置
        /// </summary>
        public sbyte? ConfigState { get; set; }
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
