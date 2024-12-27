using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisFreebetUserDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<StatisFreebetUser>, IWriteModel<StatisFreebetUser>
    {
        public StatisFreebetUserDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisFreebetUser> ReadDbSet() => _dbr.StatisFreebetUsers;

        public DbSet<StatisFreebetUser> WriteDbSet() => _dbw.StatisFreebetUsers;
    }
}
