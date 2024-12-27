using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 文档下载管理
    /// </summary>
    public partial class SyncFileDownload
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 文档名称
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// 文档名称-英文
        /// </summary>
        public string? FileNameEn { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// 下载地址
        /// </summary>
        public string? DownloadUrl { get; set; }
    }
}
