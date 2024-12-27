using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwChangeLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwChangeLog>, IWriteModel<DwChangeLog>
    {
        public DwChangeLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwChangeLog> ReadDbSet() => _dbr.DwChangeLogs;

        public DbSet<DwChangeLog> WriteDbSet()=>_dbw.DwChangeLogs;
    }
}
