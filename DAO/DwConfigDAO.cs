using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwConfigDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwConfig>, IWriteModel<DwConfig>
    {
        public DwConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwConfig> ReadDbSet() => _dbr.DwConfigs;

        public DbSet<DwConfig> WriteDbSet() => _dbw.DwConfigs;
    }
}
