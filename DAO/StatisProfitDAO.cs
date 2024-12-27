using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisProfitDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisProfit>, IWriteModel<StatisProfit>
    {
        public StatisProfitDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisProfit> ReadDbSet() => _dbr.StatisProfits;

        public DbSet<StatisProfit> WriteDbSet()=>_dbw.StatisProfits;
    }
}
