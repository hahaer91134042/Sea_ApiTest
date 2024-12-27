using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisServerLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<StatisServerLog>, IWriteModel<StatisServerLog>
    {
        public StatisServerLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisServerLog> ReadDbSet() => _dbr.StatisServerLogs;

        public DbSet<StatisServerLog> WriteDbSet()=>_dbw.StatisServerLogs;
    }
}
