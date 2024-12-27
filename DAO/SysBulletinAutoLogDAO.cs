using SEA_ApiTest.Models.ManageDb;
using SEA_ApiTest.Utils;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SysBulletinAutoLogDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<SysBulletinAutoLog>, IWriteModel<SysBulletinAutoLog>
    {
        public SysBulletinAutoLogDAO() : base(ConfigUtil.Start().CreatDbContext<ManageWriteDb>(), ConfigUtil.Start().CreatDbContext<ManageReadDb>()) { }
        public SysBulletinAutoLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SysBulletinAutoLog> ReadDbSet() => _dbr.SysBulletinAutoLogs;

        public DbSet<SysBulletinAutoLog> WriteDbSet()=>_dbw.SysBulletinAutoLogs;
    }
}
