using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 轮盘房间配置限制表
    /// </summary>
    public partial class RoomConfigRouletteLimit
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 房间名称修改   0 yes ,1 no
        /// </summary>
        public sbyte? RoomNameUpdate { get; set; }
        /// <summary>
        /// 房间标签修改  0 yes ,1 no
        /// </summary>
        public sbyte? RoomTagUpdate { get; set; }
        /// <summary>
        /// 最大人数修改   0 yes ,1 no
        /// </summary>
        public sbyte UsersMaxUpdate { get; set; }
        /// <summary>
        /// 最大局数修改   0 yes ,1 no
        /// </summary>
        public sbyte InningsMaxUpdate { get; set; }
        /// <summary>
        /// 庄家筹码上下限修改   0 yes ,1 no
        /// </summary>
        public sbyte? BankerLimitUpdate { get; set; }
        /// <summary>
        /// 下庄安全阀值修改 0 yes ,1 no
        /// </summary>
        public sbyte? DownSafeValueUpdate { get; set; }
        /// <summary>
        /// 押注筹码修改   0 yes ,1 no
        /// </summary>
        public sbyte? BetChipUpdate { get; set; }
        /// <summary>
        /// 允许玩家上庄修改   0 yes ,1 no
        /// </summary>
        public sbyte? IsUserBankerUpdate { get; set; }
        /// <summary>
        /// 玩家上下庄条件修改  0 yes ,1 no
        /// </summary>
        public sbyte? UserBankerUpdate { get; set; }
        /// <summary>
        /// 累计押注号码触发修改   0 yes ,1 no
        /// </summary>
        public sbyte? BetNumberUpdate { get; set; }
        /// <summary>
        /// 排序类型修改   0 yes ,1 no
        /// </summary>
        public sbyte? OrderTypeUpdate { get; set; }
        /// <summary>
        /// VIP限制修改   0 yes ,1 no
        /// </summary>
        public sbyte? VipLimitUpdate { get; set; }
        /// <summary>
        /// 累计押注号码限制修改 0 yes ,1 no
        /// </summary>
        public sbyte? BetNumberLimitUpdate { get; set; }
        /// <summary>
        /// 庄家续筹码修改 1 yes ,0 no
        /// </summary>
        public sbyte? BankerReplenishUpdate { get; set; }
    }
}
