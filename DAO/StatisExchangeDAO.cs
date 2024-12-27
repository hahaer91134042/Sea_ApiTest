using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisExchangeDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisExchange>
    {
        public StatisExchangeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbSet<StatisExchange> ReadDbSet() => _dbr.StatisExchanges;
    }
}
