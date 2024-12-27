using SEA_ApiTest.Models.Tpi1DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class GamemoneyDAO : BaseDAO<Tpi1ReadDb, Tpi1WriteDb>, IReadModel<Gamemoney>, IWriteModel<Gamemoney>
    {
        public GamemoneyDAO(Tpi1WriteDb dbw, Tpi1ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<Gamemoney> ReadDbSet() => _dbr.Gamemoneys;

        public DbSet<Gamemoney> WriteDbSet()=>_dbw.Gamemoneys;
    }
}
