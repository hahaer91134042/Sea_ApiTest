using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncMessageDAO :BaseDAO<ManageReadDb,ManageWriteDb> ,IReadModel<SyncMessage>,IWriteModel<SyncMessage>
    {
        public SyncMessageDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncMessage> ReadDbSet() => _dbr.SyncMessages;

        public DbSet<SyncMessage> WriteDbSet()=>_dbw.SyncMessages;
    }
}
