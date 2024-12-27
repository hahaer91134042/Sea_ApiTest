using SEA_ApiTest.Models.GameTpiDB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class PlayerActivityDataDAO : BaseDAO<GameTpiReadDb, GameTpiWriteDb>, IReadModel<PlayerActivityDatum>, IWriteModel<PlayerActivityDatum>
    {
        public PlayerActivityDataDAO(GameTpiWriteDb dbw, GameTpiReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<PlayerActivityDatum> ReadDbSet() => _dbr.PlayerActivityData;

        public DbSet<PlayerActivityDatum> WriteDbSet()=>_dbw.PlayerActivityData;
    }
}
