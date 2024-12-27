using SEA_ApiTest.Models.GameTpiDB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class GameBonusPoolDAO : BaseDAO<GameTpiReadDb,GameTpiWriteDb>, IReadModel<GameBonusPool>, IWriteModel<GameBonusPool>
    {
        public GameBonusPoolDAO(GameTpiWriteDb dbw, GameTpiReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<GameBonusPool> ReadDbSet() => _dbr.GameBonusPools;

        public DbSet<GameBonusPool> WriteDbSet()=>_dbw.GameBonusPools;
    }
}
