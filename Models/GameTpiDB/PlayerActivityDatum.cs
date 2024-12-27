using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class PlayerActivityDatum
    {
        public long Playerid { get; set; }
        public int Ep { get; set; }
        public int Lottery { get; set; }
    }
}
