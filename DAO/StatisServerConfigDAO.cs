using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisServerConfigDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisServerConfig>, IWriteModel<StatisServerConfig>
    {
        public StatisServerConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisServerConfig> ReadDbSet() => _dbr.StatisServerConfigs;

        public DbSet<StatisServerConfig> WriteDbSet()=>_dbw.StatisServerConfigs;
    }
}
