using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbManager
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public int RoleType { get; set; }
        public string? Salt { get; set; }
        public string? Name { get; set; }
        /// <summary>
        /// IP限制开关 0 关闭 1 开启
        /// </summary>
        public sbyte? IpLimit { get; set; }
        public bool IsLock { get; set; }
        public DateTime AddTime { get; set; }
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int IsControl { get; set; }
        /// <summary>
        /// 子平台标签
        /// </summary>
        public string? SubLabel { get; set; }
    }
}
