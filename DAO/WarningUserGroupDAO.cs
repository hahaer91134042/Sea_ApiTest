using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class WarningUserGroupDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<WarningUserGroup>, IWriteModel<WarningUserGroup>
    {
        public WarningUserGroupDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<WarningUserGroup> ReadDbSet() => _dbr.WarningUserGroups;

        public DbSet<WarningUserGroup> WriteDbSet() => _dbw.WarningUserGroups;
    }
}
