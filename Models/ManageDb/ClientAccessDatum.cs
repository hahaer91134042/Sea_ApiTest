using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 客户端数据收集
    /// </summary>
    public partial class ClientAccessDatum
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string? Account { get; set; }
        /// <summary>
        /// 游戏编号
        /// </summary>
        public int? GameId { get; set; }
        /// <summary>
        /// 访问唯一编号
        /// </summary>
        public string? AccessId { get; set; }
        /// <summary>
        /// 开始下载
        /// </summary>
        public DateTime? DownStart { get; set; }
        /// <summary>
        /// 文件解压
        /// </summary>
        public DateTime? FileUnrar { get; set; }
        /// <summary>
        /// 结束下载
        /// </summary>
        public DateTime? DownEnd { get; set; }
        /// <summary>
        /// 下载耗时
        /// </summary>
        public int? DownCost { get; set; }
        /// <summary>
        /// 解压耗时
        /// </summary>
        public int? UnrarCost { get; set; }
        /// <summary>
        /// 访问平台  0 未知 1 PC，2 安卓，3 IOS
        /// </summary>
        public sbyte? Terminal { get; set; }
        /// <summary>
        /// 浏览器信息
        /// </summary>
        public string? BonwserInfo { get; set; }
        /// <summary>
        /// 浏览器名称
        /// </summary>
        public string? BrowserName { get; set; }
        /// <summary>
        /// 浏览器版本
        /// </summary>
        public string? BrowserVer { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string? IpAddr { get; set; }
        /// <summary>
        /// 上网方式 0 未知，1 4G/5G  ,2  WIFI
        /// </summary>
        public sbyte? Network { get; set; }
        /// <summary>
        /// 访问状态  0  未完成，1 已完成
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 写入时间
        /// </summary>
        public DateTime? InsertTime { get; set; }
    }
}
