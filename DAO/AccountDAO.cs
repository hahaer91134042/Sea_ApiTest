using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AccountDAO : BaseDAO<Tp01ReadDb,Tp01WriteDb>, IReadModel<Account>, IWriteModel<Account>
    {
        public AccountDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Account> ReadDbSet() => _dbr.Accounts;

        public DbSet<Account> WriteDbSet()=>_dbw.Accounts;
    }
}
