using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameClassDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<SyncGameClass>, IWriteModel<SyncGameClass>
    {
        public SyncGameClassDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameClass> ReadDbSet() => _dbr.SyncGameClasses;

        public DbSet<SyncGameClass> WriteDbSet()=>_dbw.SyncGameClasses;
    }
}
