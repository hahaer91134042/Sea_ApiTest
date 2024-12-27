using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class StatisGameDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<StatisGame>, IWriteModel<StatisGame>
    {
        public StatisGameDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<StatisGame> ReadDbSet() => _dbr.StatisGames;

        public DbSet<StatisGame> WriteDbSet() => _dbw.StatisGames;
    }
}
