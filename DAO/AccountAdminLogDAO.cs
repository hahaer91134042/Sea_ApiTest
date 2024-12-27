using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class AccountAdminLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<AccountAdminLog>, IWriteModel<AccountAdminLog>
    {
        public AccountAdminLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<AccountAdminLog> ReadDbSet() => _dbr.AccountAdminLogs;

        public DbSet<AccountAdminLog> WriteDbSet()=>_dbw.AccountAdminLogs;
    }
}
