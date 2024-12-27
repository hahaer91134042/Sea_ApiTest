using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.GameTpiDB
{
    public partial class GameBonusPool
    {
        public sbyte JpLevel { get; set; }
        public uint GameId { get; set; }
        public uint? BonusMoney { get; set; }
    }
}
