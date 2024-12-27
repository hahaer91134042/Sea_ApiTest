using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏信息
    /// </summary>
    public partial class SyncGameInfo
    {
        /// <summary>
        /// 游戏ID
        /// </summary>
        public int GameId { get; set; }
        /// <summary>
        /// 语言编号
        /// </summary>
        public sbyte LanguageId { get; set; }
        /// <summary>
        /// 游戏名称
        /// </summary>
        public string GameName { get; set; } = null!;
        /// <summary>
        /// 游戏介绍
        /// </summary>
        public string Introduction { get; set; } = null!;
    }
}
