using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameOpenDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<SyncGameOpen>, IWriteModel<SyncGameOpen>
    {
        public SyncGameOpenDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameOpen> ReadDbSet() => _dbr.SyncGameOpens;

        public DbSet<SyncGameOpen> WriteDbSet()=>_dbw.SyncGameOpens;
    }
}
