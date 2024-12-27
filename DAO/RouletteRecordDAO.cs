using SEA_ApiTest.Models.Tpi1DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RouletteRecordDAO : BaseDAO<Tpi1ReadDb, Tpi1WriteDb>, IReadModel<RouletteRecord>, IWriteModel<RouletteRecord>
    {
        public RouletteRecordDAO(Tpi1WriteDb dbw, Tpi1ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RouletteRecord> ReadDbSet() => _dbr.RouletteRecords;

        public DbSet<RouletteRecord> WriteDbSet() => _dbw.RouletteRecords;
    }
}
