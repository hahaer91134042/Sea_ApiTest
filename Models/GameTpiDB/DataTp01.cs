using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class DataTp01
    {
        public long Playerid { get; set; }
        public short Gameid { get; set; }
        public sbyte Level { get; set; }
        public int? Data { get; set; }
    }
}
