using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameConfigDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncGameConfig>, IWriteModel<SyncGameConfig>
    {
        public SyncGameConfigDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public SyncGameConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameConfig> ReadDbSet() => _dbr.SyncGameConfigs;

        public DbSet<SyncGameConfig> WriteDbSet()=>_dbw.SyncGameConfigs;
    }
}
