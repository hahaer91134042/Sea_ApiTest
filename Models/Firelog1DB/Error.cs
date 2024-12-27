using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.Firelog1DB
{
    public partial class Error
    {
        public uint Uid { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Time { get; set; }
        public string? Type { get; set; }
        public string? Text { get; set; }
    }
}
