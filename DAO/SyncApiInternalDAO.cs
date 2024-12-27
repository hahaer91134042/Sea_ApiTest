using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncApiInternalDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncApiInternal>, IWriteModel<SyncApiInternal>
    {
        public SyncApiInternalDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncApiInternal> ReadDbSet() => _dbr.SyncApiInternals;

        public DbSet<SyncApiInternal> WriteDbSet()=>_dbw.SyncApiInternals;
    }
}
