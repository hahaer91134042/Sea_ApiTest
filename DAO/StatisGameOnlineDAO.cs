using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisGameOnlineDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisGameOnline>, IWriteModel<StatisGameOnline>
    {
        public StatisGameOnlineDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisGameOnline> ReadDbSet() => _dbr.StatisGameOnlines;

        public DbSet<StatisGameOnline> WriteDbSet()=>_dbw.StatisGameOnlines;
    }
}
