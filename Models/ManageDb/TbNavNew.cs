using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class TbNavNew
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? IconUrl { get; set; }
        public string? LinkUrl { get; set; }
        public int SortId { get; set; }
        public bool IsHide { get; set; }
        public string? Remark { get; set; }
        public int ActionType { get; set; }
        public int IsSys { get; set; }
    }
}
