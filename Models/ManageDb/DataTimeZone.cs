using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 时区
    /// </summary>
    public partial class DataTimeZone
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 时区
        /// </summary>
        public string? Timezone { get; set; }
        /// <summary>
        /// 当前使用  0 NO,1 YES
        /// </summary>
        public sbyte? IsUse { get; set; }
    }
}
