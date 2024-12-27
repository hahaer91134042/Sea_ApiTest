using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏跳转
    /// </summary>
    public partial class GameJump
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 跳转方式 0 无跳转，1 跳转页面，2 调用方法
        /// </summary>
        public sbyte? JumpType { get; set; }
        /// <summary>
        /// 跳转地址
        /// </summary>
        public string? JumpUrl { get; set; }
    }
}
