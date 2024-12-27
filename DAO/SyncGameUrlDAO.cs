using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameUrlDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncGameUrl>, IWriteModel<SyncGameUrl>
    {
        public SyncGameUrlDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameUrl> ReadDbSet() => _dbr.SyncGameUrls;

        public DbSet<SyncGameUrl> WriteDbSet()=>_dbw.SyncGameUrls;
    }
}
