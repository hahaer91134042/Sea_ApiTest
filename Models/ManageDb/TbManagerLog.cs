﻿using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbManagerLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? ActionType { get; set; }
        public string? Remark { get; set; }
        public string? UserIp { get; set; }
        public DateTime AddTime { get; set; }
    }
}
