using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    public partial class EventHistory
    {
        public string Dbname { get; set; } = null!;
        public string Eventname { get; set; } = null!;
        public DateTime Starttime { get; set; }
        public DateTime? Endtime { get; set; }
        public int? Issuccess { get; set; }
        public int? Duration { get; set; }
        public string? Errormessage { get; set; }
        public int? Randno { get; set; }
    }
}
