using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WarningConfigDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<WarningConfig>, IWriteModel<WarningConfig>
    {
        public WarningConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WarningConfig> ReadDbSet() => _dbr.WarningConfigs;

        public DbSet<WarningConfig> WriteDbSet()=>_dbw.WarningConfigs;
    }
}
