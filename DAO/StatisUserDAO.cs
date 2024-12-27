using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisUserDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<StatisUser>, IWriteModel<StatisUser>
    {
        public StatisUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisUser> ReadDbSet() => _dbr.StatisUsers;

        public DbSet<StatisUser> WriteDbSet()=>_dbw.StatisUsers;
    }
}
