using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbManagerRoleValue
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string? NavName { get; set; }
        public string? Action { get; set; }
    }
}
