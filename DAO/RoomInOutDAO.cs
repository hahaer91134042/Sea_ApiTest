using SEA_ApiTest.Models.Tpi1DB;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RoomInOutDAO : BaseDAO<Tpi1ReadDb, Tpi1WriteDb>, IReadModel<RoomInOut>, IWriteModel<RoomInOut>
    {
        public RoomInOutDAO(Tpi1WriteDb dbw, Tpi1ReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RoomInOut> ReadDbSet() => _dbr.RoomInOuts;

        public DbSet<RoomInOut> WriteDbSet()=>_dbw.RoomInOuts;
    }
}
