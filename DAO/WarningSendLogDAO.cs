using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WarningSendLogDAO:BaseDAO<ManageReadDb,ManageWriteDb>,IReadModel<WarningSendLog>,IWriteModel<WarningSendLog>
    {
        public WarningSendLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        //public int UnSolveCount(List<int>? roles = null)
        //{
        //    var hasRole = roles != null ? roles.Count() > 0 : false;
        //    return _dbr.WarningSendLogs
        //        .Where(x => hasRole ? roles!.Contains(x.AgentId!.Value) : true)
        //        .Count(x => x.IsSolve == 0);
        //}

        //public List<WarningSendLog> UnSolveLogs(List<int>? roles)
        //{
        //    var hasRole = roles != null ? roles.Count() > 0 : false;
        //    return (from log in _dbr.WarningSendLogs
        //            where log.IsSolve == 0
        //            where hasRole ? roles!.Contains(log.AgentId!.Value) : true
        //            select log).ToList();
        //}

        public DbContext dbw => _dbw;

        public DbSet<WarningSendLog> ReadDbSet()=>_dbr.WarningSendLogs;

        public DbSet<WarningSendLog> WriteDbSet() => _dbw.WarningSendLogs;
    }
}
