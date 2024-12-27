using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbManagerRole
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
        public int RoleType { get; set; }
        public int IsHide { get; set; }
        public int IsSys { get; set; }
        /// <summary>
        /// 是否隐藏权限组 0 NO，1 YES
        /// </summary>
        public sbyte? IsSysHide { get; set; }
    }
}
