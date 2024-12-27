using SEA_ApiTest.Models.GameTpiDB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class Game315DAO : BaseDAO<GameTpiReadDb,GameTpiWriteDb>, IReadModel<Game315>, IWriteModel<Game315>
    {
        public Game315DAO(GameTpiWriteDb dbw, GameTpiReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Game315> ReadDbSet() => _dbr.Game315s;

        public DbSet<Game315> WriteDbSet()=>_dbw.Game315s;
    }
}
