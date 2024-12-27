using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisTypeDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisType>, IWriteModel<StatisType>
    {
        public StatisTypeDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisType> ReadDbSet() => _dbr.StatisTypes;

        public DbSet<StatisType> WriteDbSet() => _dbw.StatisTypes;
    }
}
