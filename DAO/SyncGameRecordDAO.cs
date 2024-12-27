using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameRecordDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncGameRecord>, IWriteModel<SyncGameRecord>
    {
        public SyncGameRecordDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameRecord> ReadDbSet() => _dbr.SyncGameRecords;

        public DbSet<SyncGameRecord> WriteDbSet()=>_dbw.SyncGameRecords;
    }
}
