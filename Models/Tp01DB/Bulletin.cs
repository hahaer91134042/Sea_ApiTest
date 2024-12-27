using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    public partial class Bulletin
    {
        public uint Uid { get; set; }
        /// <summary>
        /// 暂时预留
        /// </summary>
        public ushort Location { get; set; }
        /// <summary>
        /// 0：纯文本，1：带转义符的超文本
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// 循环次数，-1为无限制
        /// </summary>
        public int Repeat { get; set; }
        /// <summary>
        /// 间隔，单位：秒
        /// </summary>
        public uint Interval { get; set; }
        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime Life { get; set; }
        /// <summary>
        /// 文本内容
        /// </summary>
        public string Text { get; set; } = null!;
        /// <summary>
        /// 广播次数
        /// </summary>
        public int BroadcastCount { get; set; }
        /// <summary>
        /// 广播间隔,单位：分钟
        /// </summary>
        public uint BroadcastInterv { get; set; }
        /// <summary>
        /// 上一次广播时间戳
        /// </summary>
        public DateTime BroadcastTick { get; set; }
    }
}
