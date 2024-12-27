using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisExchangeUserDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisExchangeUser>, IWriteModel<StatisExchangeUser>
    {
        public StatisExchangeUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisExchangeUser> ReadDbSet() => _dbr.StatisExchangeUsers;

        public DbSet<StatisExchangeUser> WriteDbSet()=>_dbw.StatisExchangeUsers;
    }
}
