
using SEA_ApiTest.Utils;
using System;
using System.Collections.Generic;

namespace SEA_ApiTest.Models.ManageDb
{
    /// <summary>
    /// 代理信息表
    /// </summary>
    public partial class SyncAgentInfo
    {
        //获取信任码 Md5Key
        public string GetDecryptTrustCode()
        {
            //return "ov49GQ010YhmElx0";
            //Model.sync_agent_info model = new BLL.sync_agent_infoBLL().GetModel();
            //string trustCode = (model == null ? "" : model.trust_code);
            //Log.print($"SyncAgentInfo TrustCode->{TrustCode}");
            return DESEncrypt.Decrypt(TrustCode??"");
        }

        //获取系统码 DesKey
        public string GetDecryptSysCode()
        {
            //return "SNAHYYcnPEFYLQXC";
            //Model.sync_agent_info model = new BLL.sync_agent_infoBLL().GetModel();
            //string sysCode = (model == null ? "" : model.system_code);
            return DESEncrypt.Decrypt(SystemCode ?? "");
        }


        public decimal CalHdDecimal()
        {
            //Model.sync_agent_info model = new BLL.sync_agent_infoBLL().GetModel();
            return HdDecimal == -1 ? 1 : (decimal)Math.Pow(10, HdDecimal.Value);
        }

        public decimal CalRate()=> Math.Truncate(NowCredit.toDecimal() / CreditLine.toDecimal() * 10000) / 100;

        public decimal CalRemoney() => NowCredit!.toDecimal() / CalHdDecimal();

        
    }
}
