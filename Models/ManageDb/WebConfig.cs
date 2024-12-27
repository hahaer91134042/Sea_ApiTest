using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// web参数配置
    /// </summary>
    public partial class WebConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Uid { get; set; }
        /// <summary>
        /// 类型  1 公共，2 本地
        /// </summary>
        public sbyte? Type { get; set; }
        /// <summary>
        /// 参数描述
        /// </summary>
        public string? ParamDesc { get; set; }
        /// <summary>
        /// 调用名称
        /// </summary>
        public string? ParamName { get; set; }
        /// <summary>
        /// 参数
        /// </summary>
        public string? ParamVal { get; set; }
        /// <summary>
        /// 注释
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// 是否代理必要参数 0 no ,1 yes
        /// 目前沒用
        /// </summary>
        //public sbyte? IsMust { get; set; }
        /// <summary>
        /// 校验码 由md5(type + param_desc + param_name + param_val + comment)组成
        /// </summary>
        public string? CheckCode { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string? Modifier { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }

    }
}
