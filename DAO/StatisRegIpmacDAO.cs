using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisRegIpmacDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<StatisRegIpmac>, IWriteModel<StatisRegIpmac>
    {
        public StatisRegIpmacDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisRegIpmac> ReadDbSet() => _dbr.StatisRegIpmacs;

        public DbSet<StatisRegIpmac> WriteDbSet() => _dbw.StatisRegIpmacs;
    }
}
