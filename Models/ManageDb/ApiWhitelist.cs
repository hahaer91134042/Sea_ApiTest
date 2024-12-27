using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// IP白名单
    /// </summary>
    public partial class ApiWhitelist
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string? IpAddr { get; set; }
        /// <summary>
        /// 限制类型 1 API,2 后台
        /// </summary>
        public sbyte? LimitType { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Mark { get; set; }
        /// <summary>
        /// 状态 0 正常，1 关闭，-1 删除
        /// </summary>
        public sbyte? State { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
