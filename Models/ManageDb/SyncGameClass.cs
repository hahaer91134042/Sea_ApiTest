using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏分类表
    /// </summary>
    public partial class SyncGameClass
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 语言编号
        /// </summary>
        public sbyte LanguageId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string ClassName { get; set; } = null!;
        /// <summary>
        /// 分类描述
        /// </summary>
        public string Describe { get; set; } = null!;
        /// <summary>
        /// 备用1
        /// </summary>
        public string Param1 { get; set; } = null!;
        /// <summary>
        /// 备用2
        /// </summary>
        public string Param2 { get; set; } = null!;
    }
}
