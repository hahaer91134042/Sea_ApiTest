using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisGameUserDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisGameUser>, IWriteModel<StatisGameUser>
    {
        public StatisGameUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisGameUser> ReadDbSet() => _dbr.StatisGameUsers;

        public DbSet<StatisGameUser> WriteDbSet()=>_dbw.StatisGameUsers;
    }
}
