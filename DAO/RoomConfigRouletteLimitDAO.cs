using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RoomConfigRouletteLimitDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<RoomConfigRouletteLimit>, IWriteModel<RoomConfigRouletteLimit>
    {
        public RoomConfigRouletteLimitDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RoomConfigRouletteLimit> ReadDbSet() => _dbr.RoomConfigRouletteLimits;

        public DbSet<RoomConfigRouletteLimit> WriteDbSet() => _dbw.RoomConfigRouletteLimits;
    }
}
