using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class SyncGameTypeDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<SyncGameType>, IWriteModel<SyncGameType>
    {
        public SyncGameTypeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<SyncGameType> ReadDbSet() => _dbr.SyncGameTypes;

        public DbSet<SyncGameType> WriteDbSet() => _dbw.SyncGameTypes;
    }
}
