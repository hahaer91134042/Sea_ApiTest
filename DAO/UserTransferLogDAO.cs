using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class UserTransferLogDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<UserTransferLog>, IWriteModel<UserTransferLog>
    {
        public UserTransferLogDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<UserTransferLog> ReadDbSet() => _dbr.UserTransferLogs;

        public DbSet<UserTransferLog> WriteDbSet()=>_dbw.UserTransferLogs;
    }
}
