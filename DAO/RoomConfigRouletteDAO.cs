using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class RoomConfigRouletteDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<RoomConfigRoulette>, IWriteModel<RoomConfigRoulette>
    {
        public RoomConfigRouletteDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<RoomConfigRoulette> ReadDbSet() => _dbr.RoomConfigRoulettes;

        public DbSet<RoomConfigRoulette> WriteDbSet() => _dbw.RoomConfigRoulettes;
    }
}
