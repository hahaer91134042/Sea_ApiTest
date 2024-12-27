using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WarningUserDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<WarningUser>, IWriteModel<WarningUser>
    {
        public WarningUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WarningUser> ReadDbSet() => _dbr.WarningUsers;

        public DbSet<WarningUser> WriteDbSet()=>_dbw.WarningUsers;
    }
}
