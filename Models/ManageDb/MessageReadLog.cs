using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 内部信息阅读记录
    /// </summary>
    public partial class MessageReadLog
    {
        /// <summary>
        /// 信息编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 阅读时间
        /// </summary>
        public DateTime? ReadTime { get; set; }
        /// <summary>
        /// 是否上传 0 no ,1 yes
        /// </summary>
        public sbyte? IsUpload { get; set; }
    }
}
