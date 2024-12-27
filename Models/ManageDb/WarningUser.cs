using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 警告通知人员信息
    /// </summary>
    public partial class WarningUser
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型 1 系统 ，2 本地
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 岗位
        /// </summary>
        public string? Job { get; set; }
        /// <summary>
        /// 分组-部门
        /// </summary>
        public int? GroupUid { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }
    }
}
