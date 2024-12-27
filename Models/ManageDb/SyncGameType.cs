using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 产品分类
    /// </summary>
    public partial class SyncGameType
    {
        /// <summary>
        /// 分类编号
        /// </summary>
        public sbyte TypeId { get; set; }
        /// <summary>
        /// 语言编号
        /// </summary>
        public sbyte LanguageId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string? TypeName { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string? ImageName { get; set; }
    }
}
