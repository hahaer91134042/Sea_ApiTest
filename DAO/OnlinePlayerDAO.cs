using SEA_ApiTest.Models.Tp01DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class OnlinePlayerDAO : BaseDAO<Tp01ReadDb, Tp01WriteDb>, IReadModel<OnlinePlayer>, IWriteModel<OnlinePlayer>
    {
        public OnlinePlayerDAO(Tp01WriteDb dbw, Tp01ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<OnlinePlayer> ReadDbSet() => _dbr.OnlinePlayers;

        public DbSet<OnlinePlayer> WriteDbSet()=>_dbw.OnlinePlayers;
    }
}
