using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Tp01DB
{
    /// <summary>
    /// 公告
    /// </summary>
    public partial class Notice
    {
        /// <summary>
        /// 自增编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型：1 弹框公告，2 旋转公告(特效：内容前加[1-9]。)
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// 内容
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string? Url { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string? Picture { get; set; }
        /// <summary>
        /// 是否显示，0 不显示，1 显示
        /// </summary>
        public sbyte? Isshow { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? Modifytime { get; set; }
    }
}
