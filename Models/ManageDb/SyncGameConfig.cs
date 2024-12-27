using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏配置表
    /// </summary>
    public partial class SyncGameConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        public int? ClassId { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 产品分类编号
        /// </summary>
        public sbyte? TypeId { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string? LogoUrl { get; set; }
        /// <summary>
        /// 小展示图
        /// </summary>
        public string? SmallGif { get; set; }
        /// <summary>
        /// 大展示图
        /// </summary>
        public string? BigGif { get; set; }
        /// <summary>
        /// 展示页面
        /// </summary>
        public string? ShowUrl { get; set; }
        /// <summary>
        /// 调用路径
        /// </summary>
        public string? CallPath { get; set; }
        /// <summary>
        /// 排序 升序0-100
        /// </summary>
        public int? OrderId { get; set; }
        /// <summary>
        /// 标签 1 new,2 hot,3 折扣,4 free
        /// </summary>
        public sbyte? Label { get; set; }
        /// <summary>
        /// 支持H5 0 no,1 yes
        /// </summary>
        public sbyte? SupportH5 { get; set; }
        /// <summary>
        /// 支持WebGL 0 no,1 yes
        /// </summary>
        public sbyte? SupportWebgl { get; set; }
        /// <summary>
        /// 支持APP 0 no,1 yes
        /// </summary>
        public sbyte? SupportApp { get; set; }
        /// <summary>
        /// 基础底分 彩票类使用
        /// </summary>
        public int? BasisBet { get; set; }
        /// <summary>
        /// 大卡显示倍数
        /// </summary>
        public sbyte? BigCard { get; set; }
        /// <summary>
        /// 投注默认等级 默认1
        /// </summary>
        public sbyte? BetLevel { get; set; }
        /// <summary>
        /// 免费次数 -1 不支持，其他 次数
        /// </summary>
        public int? FreeTimes { get; set; }
        /// <summary>
        /// 免费次数-游戏权重
        /// </summary>
        public int? FreeWeight { get; set; }
    }
}
