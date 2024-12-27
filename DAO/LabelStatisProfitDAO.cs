using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisProfitDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisProfit>, IWriteModel<LabelStatisProfit>
    {
        public LabelStatisProfitDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisProfit> ReadDbSet() => _dbr.LabelStatisProfits;

        public DbSet<LabelStatisProfit> WriteDbSet() => _dbw.LabelStatisProfits;
    }
}
