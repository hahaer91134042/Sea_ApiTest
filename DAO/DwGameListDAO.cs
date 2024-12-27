using SEA_ApiTest.Models.ManageDb;
using Microsoft.EntityFrameworkCore;

namespace SEA_ApiTest.DAO
{
    public class DwGameListDAO : BaseDAO<ManageReadDb, ManageWriteDb>, IReadModel<DwGameList>, IWriteModel<DwGameList>
    {
        public DwGameListDAO(ManageWriteDb dbw, ManageReadDb dbr) : base(dbw, dbr)
        {
        }

        public DbContext dbw => _dbw;

        public DbSet<DwGameList> ReadDbSet() => _dbr.DwGameLists;

        public DbSet<DwGameList> WriteDbSet()=>_dbw.DwGameLists;
    }
}
