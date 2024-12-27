using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WarningSafeDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<WarningSafe>, IWriteModel<WarningSafe>
    {
        public WarningSafeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WarningSafe> ReadDbSet() => _dbr.WarningSaves;

        public DbSet<WarningSafe> WriteDbSet()=>_dbw.WarningSaves;
    }
}
