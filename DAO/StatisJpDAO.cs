using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisJpDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisJp>, IWriteModel<StatisJp>
    {
        public StatisJpDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisJp> ReadDbSet() => _dbr.StatisJps;

        public DbSet<StatisJp> WriteDbSet() => _dbw.StatisJps;
    }
}
