using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;

namespace SEA_ApiTest.DAO
{
    public class SyncAgentInfoDAO:BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<SyncAgentInfo>,IWriteModel<SyncAgentInfo>
    {
        public SyncAgentInfo ConfigAgent { get => _agent.Value; }
        private Lazy<SyncAgentInfo> _agent { get; set; }
        public decimal ConfigHd { get => _agent.Value.CalHdDecimal(); }
        public SyncAgentInfoDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) 
        {
            _agent = new Lazy<SyncAgentInfo>(() => GetServerConfigAgent());
        }
        public SyncAgentInfoDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
            _agent=new Lazy<SyncAgentInfo>(() => GetServerConfigAgent());
        }
       

        public List<SyncAgentInfo> GetAgentList(Expression<Func<SyncAgentInfo, bool>> where, List<int>? roles = null)
        {
            var hasRole = roles != null ? roles.Count > 0 : false;
            return _dbr.SyncAgentInfos
                .Where(a => hasRole ? roles!.Contains(a.AgentId) : true)
                .Where(where)
                .ToList();
        }

        //代理列表默认条件
        public List<SyncAgentInfo> GetAgentStateList(int state=0)=>_dbw.SyncAgentInfos.Where(a=>a.State==state).ToList();

        public List<SyncAgentInfo> GetUseingAgents(List<int>? roles=null)
        {
            var hasRole = roles != null ? roles.Count > 0 : false;
            return (from a in _dbr.SyncAgentInfos
                    where a.State == 0
                    where a.GameSrvIp != string.Empty && a.GameSrvIp != "''"
                    where hasRole ? roles!.Contains(a.AgentId) : true
                    select a).ToList();
        }

        public List<SyncAgentInfo> GetDangerAgents(List<int>? roles=null)
        {
            var hasRole = roles != null ? roles.Count > 0 : false;
            return (from a in _dbr.SyncAgentInfos.Where(a=>a.State==0).ToList()
                    //where a.GameSrvIp != string.Empty && a.GameSrvIp != "''"
                    where (a.NowCredit < a.CreditLine * (decimal)0.1)
                    where hasRole ? roles!.Contains(a.AgentId) : true
                    select a).ToList();
        }

        public List<SyncAgentInfo> GetWarningAgents(List<int>? roles=null,List<SyncAgentInfo>? danger=null)
        {
            var hasRole = roles != null ? roles.Count > 0 : false;
            return (from a in _dbr.SyncAgentInfos.Where(a=>a.State==0).ToList()
                    //where a.GameSrvIp != string.Empty && a.GameSrvIp != "''"
                    where (a.NowCredit < a.CreditLine * (decimal)0.3)
                    where danger != null ? danger.Find(x => x.AgentId == a.AgentId) == null : true
                    where hasRole ? roles!.Contains(a.AgentId) : true
                    select a).ToList();
        }

        public List<SyncAgentInfo> GetCenterAgents(int? agent_id, List<int>? roles)
        {
            var hasRole = roles != null ? roles.Count > 0 : false;

            return (from a in _dbr.SyncAgentInfos
                    where a.State != -1 && a.AgentId != AppConfig.TestAgentID
                    where agent_id != null ? a.AgentId == agent_id : true
                    where hasRole ? roles!.Contains(a.AgentId) : true
                    select a).ToList();

            // whereList.Add(x => x.state != -1 && x.agent_id != 81001);   //过滤掉81001测试环境 這應該沒有

        }

        /// <summary>
        /// 获取第一条记录
        /// </summary>
        public SyncAgentInfo GetServerConfigAgent()
        {
            int agent_id = _dbr.StatisServerConfigs.Find(101)!.Value4!.toInt();
            return _dbr.SyncAgentInfos.Where(m => m.AgentId == agent_id).First();
        }

        public string ConfigTrustCode { get => _agent.Value.GetDecryptTrustCode(); }
        public string ConfigSysCode { get => _agent.Value.GetDecryptSysCode(); }

        public DbContext dbw => _dbw;
        public DbSet<SyncAgentInfo> ReadDbSet()=>_dbr.SyncAgentInfos;
        public DbSet<SyncAgentInfo> WriteDbSet()=>_dbw.SyncAgentInfos;

        public string[] DecryptApiParam(string param)
        {
            var sysCode=ConfigSysCode;
            return Util.AESDecrypt(param, sysCode, sysCode).Replace("\0", "").Split(',');
        }

        public string AESDecrypt(string token)
        {
            return Util.AESDecrypt(token,ConfigSysCode,ConfigSysCode).Replace("\0", "");
        }
    }
}
