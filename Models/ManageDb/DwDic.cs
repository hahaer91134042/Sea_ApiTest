using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class DwDic
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int LangId { get; set; }
        public string? Type { get; set; }
        public string? CallIndex { get; set; }
        public string? Val { get; set; }
        public bool IsNew { get; set; }
    }
}
