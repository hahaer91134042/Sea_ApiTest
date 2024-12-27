using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwConfigGameDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwConfigGame>, IWriteModel<DwConfigGame>
    {
        public DwConfigGameDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwConfigGame> ReadDbSet() => _dbr.DwConfigGames;

        public DbSet<DwConfigGame> WriteDbSet()=>_dbw.DwConfigGames;
    }
}
