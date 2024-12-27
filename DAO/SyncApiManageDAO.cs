using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncApiManageDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncApiManage>, IWriteModel<SyncApiManage>
    {
        public SyncApiManageDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncApiManage> ReadDbSet() => _dbr.SyncApiManages;

        public DbSet<SyncApiManage> WriteDbSet() => _dbw.SyncApiManages;
    }
}
