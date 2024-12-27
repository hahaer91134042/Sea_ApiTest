using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 游戏域名配置
    /// </summary>
    public partial class SyncGameUrl
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 用户  h5  H5访问，webgl WebGL访问
        /// </summary>
        public string? Usetype { get; set; }
        /// <summary>
        /// 游戏域名
        /// </summary>
        public string? GameUrl { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string? Ipaddress { get; set; }
        /// <summary>
        /// 排序  1-10 升序，同ucr_uid,url_type排序
        /// </summary>
        public sbyte? Sort { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
    }
}
