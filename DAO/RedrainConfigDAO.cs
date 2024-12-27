using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RedrainConfigDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<RedrainConfig>, IWriteModel<RedrainConfig>
    {
        public RedrainConfigDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RedrainConfig> ReadDbSet() => _dbr.RedrainConfigs;

        public DbSet<RedrainConfig> WriteDbSet()=>_dbw.RedrainConfigs;
    }
}
