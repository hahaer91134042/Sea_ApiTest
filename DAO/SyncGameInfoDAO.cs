using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameInfoDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<SyncGameInfo>, IWriteModel<SyncGameInfo>
    {
        public SyncGameInfoDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public SyncGameInfoDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameInfo> ReadDbSet() => _dbr.SyncGameInfos;

        public DbSet<SyncGameInfo> WriteDbSet() => _dbw.SyncGameInfos;
    }
}
