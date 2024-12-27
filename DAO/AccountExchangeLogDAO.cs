using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AccountExchangeLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<AccountExchangeLog>, IWriteModel<AccountExchangeLog>
    {
        public AccountExchangeLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<AccountExchangeLog> ReadDbSet() => _dbr.AccountExchangeLogs;

        public DbSet<AccountExchangeLog> WriteDbSet()=>_dbw.AccountExchangeLogs;
    }
}
