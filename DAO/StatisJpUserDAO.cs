using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisJpUserDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisJpUser>, IWriteModel<StatisJpUser>
    {
        public StatisJpUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisJpUser> ReadDbSet() => _dbr.StatisJpUsers;

        public DbSet<StatisJpUser> WriteDbSet()=>_dbw.StatisJpUsers;
    }
}
