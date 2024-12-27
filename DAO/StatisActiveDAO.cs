using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisActiveDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisActive>, IWriteModel<StatisActive>
    {
        public StatisActiveDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisActive> ReadDbSet() => _dbr.StatisActives;

        public DbSet<StatisActive> WriteDbSet()=>_dbw.StatisActives;
    }
}
