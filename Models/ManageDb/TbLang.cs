using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbLang
    {
        public int Id { get; set; }
        public int AppId { get; set; }
        public string? Title { get; set; }
        public bool IsDefault { get; set; }
        public DateTime AddTime { get; set; }
    }
}
