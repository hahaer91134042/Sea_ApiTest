using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class LabelStatisGameDAO : BaseDAO<ManageReadDb,ManageWriteDb>, IReadModel<LabelStatisGame>, IWriteModel<LabelStatisGame>
    {
        public LabelStatisGameDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<LabelStatisGame> ReadDbSet() => _dbr.LabelStatisGames;

        public DbSet<LabelStatisGame> WriteDbSet() => _dbw.LabelStatisGames;
    }
}
