using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tpi1DB
{
    /// <summary>
    /// 字典管理
    /// </summary>
    public partial class DictionaryManaged
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// 语言ID
        /// </summary>
        public sbyte? LanguageId { get; set; }
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; } = null!;
        /// <summary>
        /// 表描述
        /// </summary>
        public string TableDescribe { get; set; } = null!;
        /// <summary>
        /// 字段名
        /// </summary>
        public string ColumnName { get; set; } = null!;
        /// <summary>
        /// 字段值
        /// </summary>
        public int ColumnValue { get; set; }
        /// <summary>
        /// 值描述
        /// </summary>
        public string ValueDescribe { get; set; } = null!;
    }
}
