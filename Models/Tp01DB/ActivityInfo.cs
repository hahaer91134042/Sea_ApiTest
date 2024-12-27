using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 活动管理
    /// </summary>
    public partial class ActivityInfo
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// 展示图标
        /// </summary>
        public string PictureAddr { get; set; } = null!;
        /// <summary>
        /// 跳转链接
        /// </summary>
        public string LinkAddr { get; set; } = null!;
        /// <summary>
        /// 是否显示 0 不显示，1 显示
        /// </summary>
        public sbyte IsShow { get; set; }
        /// <summary>
        /// 排序权值 0-100 小则最前
        /// </summary>
        public sbyte OrderValue { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string Modifier { get; set; } = null!;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }
    }
}
