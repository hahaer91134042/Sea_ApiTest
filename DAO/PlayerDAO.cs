using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class PlayerDAO : BaseDAO<Tp01ReadDb, Tp01WriteDb>, IReadModel<Player>, IWriteModel<Player>
    {
        public PlayerDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Player> ReadDbSet() => _dbr.Players;

        public DbSet<Player> WriteDbSet()=>_dbw.Players;
    }
}
